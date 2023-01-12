using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    public partial class FormClient
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
            AddMessageToHistory += $"[{DateTime.Now}]{Environment.NewLine}->";

            foreach (byte element in request)
                AddMessageToHistory += $" {element:X2}";

            AddMessageToHistory += $"{Environment.NewLine}<-";

            foreach (byte element in response)
                AddMessageToHistory += $" {element:X2}";

            AddMessageToHistory += $"{Environment.NewLine}{Environment.NewLine}";
        }

        public void VerifyExceptionCode(byte[] response, int index)
        {
            switch (response[index])
            {
                case 0x01:
                    ExceptionTitle = "Exception Code 01: Illegal Function";
                    ExceptionMessage = "'The function code received in the query is not an allowable action for the slave.'";
                    break;

                case 0x02:
                    ExceptionTitle = "Exception Code 02: Illegal Data Address";
                    ExceptionMessage = "'The data address received in the query is not an allowable address for the slave.'";
                    break;

                case 0x03:
                    ExceptionTitle = "Exception Code 03: Illegal Data Value";
                    ExceptionMessage = "'A value contained in the query data field is not an allowable value for the slave.'";
                    break;

                case 0x04:
                    ExceptionTitle = "Exception Code 04: Slave Device Failure";
                    ExceptionMessage = "'An unrecoverable error occurred while the slave was attempting to perform the requested action.'";
                    break;

                case 0x0A:
                    ExceptionTitle = "Exception Code 0A: Gateway Path Unavailable";
                    ExceptionMessage = "'The gateway was unable to allocate an internal communication path from the input port to the " +
                                        "output port for processing the request.'";
                    break;

                default:
                    customTextBoxPrintAnalyze.Texts = "Exception code in response.";
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
                        customTextBoxPrintAnalyze.Texts = $"The function code in the response has its highest bit set. {Environment.NewLine}";

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
                            MessageBox.Show("An error occurred.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                        customTextBoxPrintAnalyze.Texts = "Incorrect response.";
                }
                else
                    customTextBoxPrintAnalyze.Texts = "Different Slave ID in the response.";
            }
            else
                customTextBoxPrintAnalyze.Texts = "Incorrect response.";
        }

        public void ReadDataFromResponse(byte[] response)
        {
            int counterRegisters = 0;

            if (selected03)
            {
                customTextBoxPrintAnalyze.Texts = $"Device: {comboSlave.SelectedItem} {Environment.NewLine}Command: Read Holding Registers {Environment.NewLine}" +
                                                  $"Address: {customTextBoxDataAddress.Texts} {Environment.NewLine}Number of registers: {Convert.ToInt32(customTextBoxDataRegisters.Texts)} {Environment.NewLine}{Environment.NewLine}";
                customTextBoxPrintAnalyze.Texts += $"In response: {Environment.NewLine}";
                customTextBoxPrintAnalyze.Texts += $"The contents of requested registers: {Convert.ToInt32(response[(int)Message.NumberOfBytes])} bytes";

                for (int index = (int)Message.ContentOfFirstRegister; index <= (response.Length - 1); index++)
                {
                    if (counterRegisters % 2 == 0)
                    {
                        customTextBoxPrintAnalyze.Texts += $"{Environment.NewLine}-register no.{counterRegisters / 2 + 1}: ";
                        customTextBoxPrintAnalyze.Texts += $"{response[index]:X2}"; ;
                    }
                    else
                        customTextBoxPrintAnalyze.Texts += $"{response[index]:X2}"; ;

                    counterRegisters++;
                }
            }
            else if (selected06)
            {
                customTextBoxPrintAnalyze.Texts = $"Device: {comboSlave.SelectedItem} {Environment.NewLine}Command: Preset Single Register {Environment.NewLine}{Environment.NewLine}";
                customTextBoxPrintAnalyze.Texts += $"In response: The value {response[(int)(DataField.HiByteOfRegister)]}{response[(int)(DataField.LoByteOfRegister)]} " +
                                            $"was written at address {response[(int)(DataField.HiRegisterAddressByte)]}{response[(int)(DataField.LoRegisterAddressByte)]}";
            }
            else if (selected16)
            {
                customTextBoxPrintAnalyze.Texts = $"Device: {comboSlave.SelectedItem} {Environment.NewLine}Command: Preset Multiple Registers {Environment.NewLine}Values: {customTextBoxDataValues.Texts} {Environment.NewLine}{Environment.NewLine}";
                customTextBoxPrintAnalyze.Texts += $"In response: {Convert.ToInt32(response[(int)(DataField.LoByteOfRegister)])} registers written " +
                                            $"starting with address {response[(int)(DataField.HiRegisterAddressByte)]:X2}{response[(int)(DataField.LoRegisterAddressByte)]:X2}\n";
            }
        }

    }
}
