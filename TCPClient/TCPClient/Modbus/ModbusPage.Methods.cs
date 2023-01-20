using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient.Modbus
{
    public partial class ModbusPage
    {
        FunctionCodes fc = new FunctionCodes();
        System.Diagnostics.Stopwatch executionTime = new System.Diagnostics.Stopwatch();

        public void BuildRequest(byte[] request, string transactionId, short protocolId, byte slaveId, byte functionCode, string dataAddress, string dataRegisters, string dataValue)
        {
            if (selected03)
                fc.ReadHoldingRegisters(request, transactionId, protocolId, slaveId, functionCode, dataAddress, dataRegisters);
            else if (selected06)
                fc.PresetSingleRegister(request, transactionId, protocolId, slaveId, functionCode, dataAddress, dataValue);
            else if (selected16)
                fc.PresetMultipleRegisters(request, transactionId, protocolId, slaveId, functionCode, dataAddress, dataRegisters, dataValue);
        }

        public void AddToHistory(byte[] request, byte[] response)
        {
            //printing date and time 
            AddMessageToHistory += $"[{DateTime.Now}]{Environment.NewLine}->";

            //Adding the Request message
            foreach (byte element in request)
                AddMessageToHistory += $" {element:X2}";

            AddMessageToHistory += $"{Environment.NewLine}<-";

            //Adding the Response message
            foreach (byte element in response)
                AddMessageToHistory += $" {element:X2}";

            AddMessageToHistory += $"{Environment.NewLine}{Environment.NewLine}";
        }

        public void VerifyExceptionCode(byte[] response, int index)
        {
            switch (response[index])
            {
                //HERE ADD NEW INFO BESIDES THIS
                case 0x01:
                    ExceptionTitle = $"In response: {Environment.NewLine}" +
                                     $"The function code has its highest bit set. {Environment.NewLine}" +
                                     $"Exception Code 01: Illegal Function. {Environment.NewLine}";

                    ExceptionMessage = $"Info: 'The function code received in the query is not an allowable action for the slave.' {Environment.NewLine}" +
                                       $"-> received function code: {functionCode} ";
                    break;

                case 0x02:
                    ExceptionTitle = $"In response: {Environment.NewLine}" +
                                     $"The function code has its highest bit set. {Environment.NewLine}" +
                                     $"Exception Code 02: Illegal Data Address.{Environment.NewLine}";

                    ExceptionMessage = $"Info: 'The data address received in the query is not an allowable address for the slave.' {Environment.NewLine}" +
                                       $"-> address: {customTextBoxDataAddress.Texts}";
                    break;

                case 0x03:
                    ExceptionTitle = $"In response: {Environment.NewLine} " +
                                     $"The function code has its highest bit set. {Environment.NewLine}" +
                                     $"Exception Code 03: Illegal Data Value.{Environment.NewLine}";

                    ExceptionMessage = $"Info: 'A value contained in the query data field is not an allowable value for the slave.' {Environment.NewLine}" +
                                       $"-> values: {customTextBoxDataValues.Texts}";
                    break;

                case 0x04:
                    ExceptionTitle = $"In response:{Environment.NewLine}" +
                                     $"The function code has its highest bit set. {Environment.NewLine}" +
                                     $"Exception Code 04: Slave Device Failure.{Environment.NewLine}";

                    ExceptionMessage = $"Info: 'An unrecoverable error occurred while the slave was attempting to perform the requested action.' {Environment.NewLine}" +
                                       $"-> device: {comboSlave.SelectedItem}, ID: {customTextBoxSlaveId.Texts} {Environment.NewLine}" +
                                       $"-> command: {comboFunctionCode.SelectedItem} {Environment.NewLine}";
                    break;
                   
                case 0x0A:
                    ExceptionTitle = $"In response: {Environment.NewLine} " +
                                     $"The function code has its highest bit set. {Environment.NewLine}" +
                                     $"Exception Code 0A: Gateway Path Unavailable.{Environment.NewLine}";

                    ExceptionMessage = $"Info: 'The gateway was unable to allocate an internal communication path from the input port to the " +
                                       $"output port for processing the request.'{Environment.NewLine}" +
                                       $"-> device: {comboSlave.SelectedItem}, ID: {customTextBoxSlaveId.Texts}";
                    break;

                default:
                    customTextBoxPrintAnalyze.Texts = "The function code in the response has its highest bit set.";
                    break;
            }
        }

        public void AnalyzeResponse(byte[] response, byte[] request)
        {
            customTextBoxPrintAnalyze.Enable = true;

            if ((response[(int)Message.TransactionId] == request[(int)Message.TransactionId]) && (response[(int)Message.ProtocolId] == request[(int)Message.ProtocolId]))
            {
                if (response[(int)Message.SlaveId] == request[(int)Message.SlaveId])
                {
                    if (response[(int)Message.FunctionCode] == request[(int)Message.FunctionCode])
                    {
                        ReadDataFromResponse(response);
                        AddToHistory(request, response);
                    }
                    else if (response[(int)Message.FunctionCode] == highestBitSet + request[(int)Message.FunctionCode])
                    {
                        //this message goes to switch -> in the Exception Form (eg FC: 83 -> ....) 

                        VerifyExceptionCode(response, (int)(Message.FunctionCode + 1));
                        AddToHistory(request, response);

                        customTextBoxPrintRequest.Texts = String.Empty;
                        customTextBoxPrintResponse.Texts = String.Empty;
                        customTextBoxPrintAnalyze.Texts = String.Empty;

                        try
                        {
                            FormExceptionCode formException = new FormExceptionCode();
                            formException.Show();
                        }
                        catch
                        {
                            MessageBox.Show("An error occurred while opening the exception message.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                        customTextBoxPrintAnalyze.Texts = "Incorrect Function Code in the response.";
                }
                else
                    customTextBoxPrintAnalyze.Texts = "Different Slave ID in the response.";
            }
            else
                customTextBoxPrintAnalyze.Texts = "Incorrect response.";
        }

        public void ReadDataFromResponse(byte[] response)
        {
            if (selected03)
            {
                customTextBoxPrintAnalyze.Texts = $"Device: {comboSlave.SelectedItem} {Environment.NewLine}" +
                                                  $"Command: Read Holding Registers {Environment.NewLine}" +
                                                  $"Address: {customTextBoxDataAddress.Texts} {Environment.NewLine}" +
                                                  $"Number of registers: {customTextBoxDataRegisters.Texts} {Environment.NewLine}{Environment.NewLine}";

                customTextBoxPrintAnalyze.Texts += $"In response: {Environment.NewLine}" +
                                                   $"The contents of requested registers: {Convert.ToInt32(response[(int)Message.NumberOfBytes])} bytes";

                int counterRegisters = 0; //used for printing the format "-register no. X" only on even cases

                for (int index = (int)Message.ContentOfFirstRegister; index <= (response.Length - 1); index++) //int index = 9;
                {
                    if (counterRegisters % 2 == 0)
                        customTextBoxPrintAnalyze.Texts += $"{Environment.NewLine} -register no.{counterRegisters / 2 + 1}: {response[index]:X2}"; // for eg. when counterRegisters = 4, index = 3 => 4/2+1 = 3 
                    else
                        customTextBoxPrintAnalyze.Texts += $"{response[index]:X2}";

                    counterRegisters++;
                }
            }
            else if (selected06)
            {
                customTextBoxPrintAnalyze.Texts = $"Device: {comboSlave.SelectedItem} {Environment.NewLine}" +
                                                  $"Command: Preset Single Register   {Environment.NewLine}{Environment.NewLine}";

                customTextBoxPrintAnalyze.Texts += $"In response: The value {response[(int)(DataField.HiByteOfRegister)]}{response[(int)(DataField.LoByteOfRegister)]} " +
                                                   $"was written at the address {response[(int)(DataField.HiRegisterAddressByte)]}{response[(int)(DataField.LoRegisterAddressByte)]}";
            }
            else if (selected16)
            {
                customTextBoxPrintAnalyze.Texts = $"Device: {comboSlave.SelectedItem} {Environment.NewLine}" +
                                                  $"Command: Preset Multiple Registers {Environment.NewLine}" +
                                                  $"Values: {customTextBoxDataValues.Texts} {Environment.NewLine}{Environment.NewLine}";

                customTextBoxPrintAnalyze.Texts += $"In response: {Convert.ToInt32(response[(int)(DataField.LoByteOfRegister)])} registers written " +
                                                   $"with the starting address {response[(int)(DataField.HiRegisterAddressByte)]:X2}{response[(int)(DataField.LoRegisterAddressByte)]:X2}\n";
            }
        }

    }
}
