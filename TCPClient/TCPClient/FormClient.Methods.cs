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

        public void AnalyzeResponse(byte[] response, byte[] request)
        {
            richtxtAnalyzeResponse.Enabled = true;

            if ((response[(int)Header.TransactionId] == request[(int)Header.TransactionId]) && (response[(int)Header.ProtocolId] == request[(int)Header.ProtocolId]))
            {
                if (response[(int)Header.SlaveId] == request[(int)Header.SlaveId])
                {
                    if (response[(int)MessageStructure.FunctionCode] == request[(int)MessageStructure.FunctionCode])
                    {
                        richtxtAnalyzeResponse.Text = "Correct response.";

                        AddToHistory(request, response);
                        // add to history only the correct responses?
                    }
                    else if (response[(int)MessageStructure.FunctionCode] == highestBitSet + request[(int)MessageStructure.FunctionCode])
                    {
                        richtxtAnalyzeResponse.Text = "The function code in the response has its highest bit set.";

                        switch (response[(int)MessageStructure.ExceptionCode])
                        {
                            case 0x02:
                                richtxtAnalyzeResponse.Text += "\nException Code 02: Illegal Data Address. " +
                                                               "\n\n'The data address received in the query is not an allowable address for the slave.'";
                                break;

                            case 0x03:
                                richtxtAnalyzeResponse.Text += "\nException Code 03: Illegal Data Value. " +
                                                               "\n\n'A value contained in the query data field is not an allowable value for the slave.'";
                                break;

                            case 0x0A:
                                richtxtAnalyzeResponse.Text += "\nException Code 0A: Gateway Path Unavailable. " +
                                                               "\n\n'The gateway was unable to allocate an internal communication path from " +
                                                               "the input port to the output port for processing the request.'";
                                break;

                            default:
                                richtxtAnalyzeResponse.Text = "\nException response.";
                                break;
                        }
                    }
                    else
                        richtxtAnalyzeResponse.Text = "Incorrect response.";
                }
                else
                    richtxtAnalyzeResponse.Text = "Different Slave ID in the response.";
            }
            else
                richtxtAnalyzeResponse.Text = "Incorrect response.";
        }

    }
}
