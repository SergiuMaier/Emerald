using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    public partial class FormClient
    {
        enum Header
        {
            TransactionId = 0,
            ProtocolId = 2,
            SlaveId = 6
        }

        enum MessageStructure
        {
            FunctionCode = 7,
            ExceptionCode = 8
        }
        public static string addMessageToHistory = "";
   
        public int counterNoOfRegisters;
        public int counterTransactionId;
        public byte functionCode, slaveId;

        public const short protocolId = 0x0000;
        public const byte COM100Id = 0xFF;
        public const byte fc03 = 0x03, fc06 = 0x06, fc16 = 0x10;
        public const byte header_Length = 0x06;
        public const byte slaveId_Length = 0x01;
        public const byte functionCode_Length = 0x01;
        public const byte dataAddress_Length = 0x02;
        public const byte dataRegisters_Length = 0x02;
        public const byte numberOfBytesToFollow_Length = 0x01;

        public byte[] bufferRequest;
        public byte[] bufferResponse;

        bool selected03, selected06, selected16;

        byte bufferLength03 = header_Length + slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte bufferLength06 = header_Length + slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte bufferLength16 = header_Length + slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length + numberOfBytesToFollow_Length;
    }
}
