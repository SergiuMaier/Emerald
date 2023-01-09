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
            addMessageToHistory += $"[{DateTime.Now}]{Environment.NewLine}->";

            foreach (byte element in request)
                addMessageToHistory += $" {element:X2}";

            addMessageToHistory += $"{Environment.NewLine}<-";

            foreach (byte element in response)
                addMessageToHistory += $" {element:X2}";

            addMessageToHistory += $"{Environment.NewLine}{Environment.NewLine}";
        }

        public void VerifyExceptionCode(byte[] response, int index)
        {
            switch (response[index])
            {
                case 0x01:
                    exceptionMessage = "Exception Code 01: Illegal Function. " +
                                     "\n'The function code received in the query is not an allowable action for the slave.'";
                    break;

                case 0x02:
                    exceptionMessage = "Exception Code 02: Illegal Data Address. " +
                                     "\n'The data address received in the query is not an allowable address for the slave.'";
                    break;

                case 0x03:
                    exceptionMessage = "Exception Code 03: Illegal Data Value. " +
                                     "\n'A value contained in the query data field is not an allowable value for the slave.'";
                    break;

                case 0x04:
                    exceptionMessage = "Exception Code 04: Slave Device Failure. " +
                                     "\n'An unrecoverable error occurred while the slave was attempting to perform the requested action.'";
                    break;

                case 0x0A:
                    exceptionMessage = "Exception Code 0A: Gateway Path Unavailable. " +
                                     "\n'The gateway was unable to allocate an internal communication path from the input port to the " +
                                        "output port for processing the request.'";
                    break;

                default:
                    richtxtPrintAnalyze.Text = "\nException response.";
                    break;
            }
        }

        public void AnalyzeResponse(byte[] response, byte[] request)
        {
            richtxtPrintAnalyze.Enabled = true;

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
                        richtxtPrintAnalyze.Text = "The function code in the response has its highest bit set.";

                        VerifyExceptionCode(response, (int)(Message.FunctionCode + 1));
                        AddToHistory(request, response);

                        richtxtPrintRequest.Text = String.Empty;
                        richtxtPrintResponse.Text = String.Empty;
                        richtxtPrintAnalyze.Text = String.Empty;

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
                        richtxtPrintAnalyze.Text = "Incorrect response.";
                }
                else
                    richtxtPrintAnalyze.Text = "Different Slave ID in the response.";
            }
            else
                richtxtPrintAnalyze.Text = "Incorrect response.";
        }

        public void ReadDataFromResponse(byte[] response)
        {
            int counterRegisters = 0;

            if (selected03)
            {
                richtxtPrintAnalyze.Text = $"Device: {comboSlave.SelectedItem}\nFC 03: Read Holding Registers\nAddress: {richtxtDataAddress.Text}\nNumber of registers: {Convert.ToInt32(richtxtDataRegisters.Text)}\n\n";
                richtxtPrintAnalyze.Text += "In response: ";
                richtxtPrintAnalyze.Text += $"\n The contents of requested registers: {Convert.ToInt32(response[(int)Message.NumberOfBytes])} bytes";

                for (int index = (int)Message.ContentOfFirstRegister; index <= (response.Length - 1); index++)
                {
                    if (counterRegisters % 2 == 0)
                    {
                        richtxtPrintAnalyze.Text += $"\n -register no.{counterRegisters / 2 + 1}: ";
                        richtxtPrintAnalyze.Text += $"{response[index]:X2}"; ;
                    }
                    else
                        richtxtPrintAnalyze.Text += $"{response[index]:X2}"; ;

                    counterRegisters++;
                }
            }
            else if (selected06)
            {
                richtxtPrintAnalyze.Text = $"Device: {comboSlave.SelectedItem}\nFC06: Preset Single Register\n\n";
                richtxtPrintAnalyze.Text += $"In response: The value {response[(int)(DataField.HiByteOfRegister)]}{response[(int)(DataField.LoByteOfRegister)]} " +
                                            $"was written at address {response[(int)(DataField.HiRegisterAddressByte)]}{response[(int)(DataField.LoRegisterAddressByte)]}";
            }
            else if (selected16)
            {
                richtxtPrintAnalyze.Text = $"Device: {comboSlave.SelectedItem}\nFC 16: Preset Multiple Registers\nValues: {richtxtDataValues.Text}\n\n";
                richtxtPrintAnalyze.Text += $"In response: {Convert.ToInt32(response[(int)(DataField.LoByteOfRegister)])} registers written " +
                                            $"starting with address {response[(int)(DataField.HiRegisterAddressByte)]:X2}{response[(int)(DataField.LoRegisterAddressByte)]:X2}\n";
            }
        }

    }
}
