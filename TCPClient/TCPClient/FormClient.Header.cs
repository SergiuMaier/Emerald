using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    public partial class FormClient
    {
        enum Header { TransactionId = 0, ProtocolId = 2, SlaveId = 6 }
        enum MessageStructure { FunctionCode = 7, ExceptionCode = 8 }

        public int counterTransactionId;    //this counter is incremented for each request. 
        public int counterNoOfRegisters;    //the value can increase or decrease, to get the desired number of registers.

        bool selected03, selected06, selected16;  //flags set when one of the commands is selected
        
        public byte[] bufferRequest;    //buffer used to store all bytes from the request message
        public byte[] bufferResponse;   //buffer used to store all bytes from the response message

        public const byte COM100Id = 0xFF;    //1 byte, uniquely identify the Slave device.

        public const short protocolId = 0x0000;                   //2 bytes, Modbus protocol, will allways be 00 00.
        public const byte fc03 = 0x03, fc06 = 0x06, fc16 = 0x10;  //1 byte, function codes.
        public byte functionCode, slaveId;                        //the bytes for function code and slave id are stored here.

        public const byte header_Length = 0x07;                 //7 bytes, MBAP Header (transactionID + protocolID + Length + SlaveId)   

        //the number of bytes for each element in the message that follow after the header
        public const byte functionCode_Length = 0x01;             
        public const byte dataAddress_Length = 0x02;             
        public const byte dataRegisters_Length = 0x02;            
        public const byte numberOfBytesToFollow_Length = 0x01;

        //the buffer length varies depending on the selected function code 
        byte bufferLength03 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte bufferLength06 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte bufferLength16 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length + numberOfBytesToFollow_Length;

        public static string addMessageToHistory = "";  //the desired message is sent to FormHistory

    }
}
