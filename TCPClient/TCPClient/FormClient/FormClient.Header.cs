using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    public partial class FormClient
    {
        enum Message 
        { 
            TransactionId = 0, 
            ProtocolId = 2, 
            SlaveId = 6, 
            FunctionCode = 7, 
            NumberOfBytes = 8, 
            ContentOfFirstRegister = 9 
        }
        enum DataField 
        {
            HiRegisterAddressByte = 8,
            LoRegisterAddressByte = 9,
            HiByteOfRegister = 10,
            LoByteOfRegister = 11
        }

        public int counterTransactionId;    //this counter is incremented for each request. 
        public int counterNoOfRegisters = 1;    //the value can increase or decrease, to get the desired number of registers.

        bool selected03, selected06, selected16;  //flags set when one of the commands is selected
        
        public byte[] requestBuffer;    //buffer used to store all bytes from the request message
        public byte[] responseBuffer;   //buffer used to store all bytes from the response message

        public short protocolId = 0x0000;     //2 bytes, Modbus protocol, will allways be 00 00.
        public const byte COM100Id = 0xFF;          //1 byte, uniquely identify the Slave device.

        public const byte fc03 = 0x03, fc06 = 0x06, fc16 = 0x10;  //1 byte, function codes.
        public byte functionCode, slaveId;                        //the bytes for function code and slave id are stored here.

        public const byte header_Length = 0x07;   //7 bytes, MBAP Header (transactionID + protocolID + Length + SlaveId)   

        //the number of bytes for each element in the message that follow after the header
        public const byte functionCode_Length = 0x01;             
        public const byte dataAddress_Length = 0x02;             
        public const byte dataRegisters_Length = 0x02;            
        public const byte numberOfBytesToFollow_Length = 0x01;
        public const byte highestBitSet = 0x80;

        //the buffer length varies depending on the selected function code 
        byte bufferLength;
        byte lengthCase03 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte lengthCase06 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte lengthCase16 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length + numberOfBytesToFollow_Length;

        public static string addMessageToHistory = "";  //the desired message is sent to FormHistory
        public static string exceptionMessage = "";     //used to send the exception message to FormException
    }
}
