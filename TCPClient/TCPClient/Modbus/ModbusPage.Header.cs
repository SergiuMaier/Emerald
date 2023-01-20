using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient.Modbus
{
    public partial class ModbusPage
    {
        //Commands added to comboFunctionCode
        enum Commands
        {
            Read_Holding_Registers,
            Preset_Single_Register,
            Preset_Multiple_Registers
        }

        //Deices added to comboSlave
        enum Devices
        {
            COM100,
            New_Device
        }

        //Buffer indexes from Modbus frame
        enum Message
        {
            TransactionId = 0,
            ProtocolId = 2,
            SlaveId = 6,
            FunctionCode = 7,
            NumberOfBytes = 8,
            ContentOfFirstRegister = 9
        }

        //Buffer indexes only for Data field in Modbus frame
        enum DataField
        {
            HiRegisterAddressByte = 8,
            LoRegisterAddressByte = 9,
            HiByteOfRegister = 10,
            LoByteOfRegister = 11
        }

        public bool connectionStatus = false;    //flag used to check whether the client is connected or not (client.isConnected method sometimes throws an exception)
        private int counterTransactionId;        //counter incremented for each request. 
        private int counterNoOfRegisters = 1;    //counter which stores the desired number of registers.

        bool selected03, selected06, selected16; //flags set when one of the commands is selected.

        private byte[] requestBuffer;    //buffer used to store all bytes from the request message.
        private byte[] responseBuffer;   //buffer used to store all bytes from the response message.

        private short protocolId;            //2 bytes, Modbus protocol, will allways be 00 00.
        public const byte COM100Id = 0xFF;   //1 byte, uniquely identify the Slave device.

        public const byte fc03 = 0x03, fc06 = 0x06, fc16 = 0x10;  //1 byte, function codes.
        private byte functionCode;
        private byte slaveId;                     //the bytes for function code and slave id are stored here.

        public const byte header_Length = 0x07;   //7 bytes for MBAP Header (transactionID + protocolID + Length + SlaveId).  

        //the number of bytes for each element in the message that follow after the header.
        public const byte functionCode_Length = 0x01;
        public const byte dataAddress_Length = 0x02;
        public const byte dataRegisters_Length = 0x02;
        public const byte numberOfBytesToFollow_Length = 0x01;
        public const byte highestBitSet = 0x80;

        //buffer's length varies depending on the selected command
        byte bufferLength;
        byte lengthCase03 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte lengthCase06 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte lengthCase16 = header_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length + numberOfBytesToFollow_Length;

        private static string numberOfRegisters;    //the number of registers needs to be converted to hex before is sent (in the request).
        private static string addMessageToHistory;  //the desired message is sent to FormHistory.
        private static string exceptionTitle;       //used to send the exception title to FormException.
        private static string exceptionMessage;     //used to send the exception message to FormException.

        //Properties
        public static string AddMessageToHistory
        {
            get
            {
                return addMessageToHistory;
            }

            set
            {
                addMessageToHistory = value;
            }
        }

        public static string ExceptionTitle
        {
            get
            {
                return exceptionTitle;
            }

            set
            {
                exceptionTitle = value;
            }
        }

        public static string ExceptionMessage
        {
            get
            {
                return exceptionMessage;
            }

            set
            {
                exceptionMessage = value;
            }
        }

        public int CounterTransactionId
        {
            get
            {
                return counterTransactionId;
            }

            set
            {
                counterTransactionId = value;
            }
        }

        public int CounterNoOfRegisters
        {
            get
            {
                return counterNoOfRegisters;
            }

            set
            {
                counterNoOfRegisters = value;
            }
        }

        public byte[] RequestBuffer
        {
            get
            {
                return requestBuffer;
            }

            set
            {
                requestBuffer = value;
            }
        }

        public byte[] ResponseBuffer
        {
            get
            {
                return responseBuffer;
            }

            set
            {
                responseBuffer = value;
            }
        }

        public short ProtocolId
        {
            get
            {
                return protocolId;
            }

            set
            {
                protocolId = value;
            }
        }

        public byte FunctionCode
        {
            get
            {
                return functionCode;
            }

            set
            {
                functionCode = value;
            }
        }

        public byte SlaveId
        {
            get
            {
                return slaveId;
            }

            set
            {
                slaveId = value;
            }
        }
        public static string NumberOfRegisters
        {
            get
            {
                return numberOfRegisters;
            }

            set
            {
                numberOfRegisters = value;
            }
        }
    }
}
