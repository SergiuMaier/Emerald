using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    public class FunctionCodes
    {
        enum RequestStructure
        {
            TransactionId = 0,
            ProtocolId = 2,
            Length = 4,
            SlaveId = 6,
            FunctionCode = 7,
            DataAddress = 8,
            DataRegisters = 10,
            NumberOfBytesToFollow = 12,
            FirstRegisterValue = 13 //fc10
        }

        public const byte slaveId_Length = 0x01;
        public const byte functionCode_Length = 0x01;
        public const byte dataAddress_Length = 0x02;
        public const byte dataRegisters_Length = 0x02;
        public const byte numberOfBytesToFollow_Length = 0x01;

        /// <summary>
        /// Adding two bytes to a buffer.
        /// </summary>
        /// <param name="buffer">A buffer in which 2 bytes will be stored.</param>
        /// <param name="number">A 16-bit signed integer number.</param>
        /// <param name="indexBuffer">The buffer location where the first byte will be stored.</param>
        public static void AddTwoBytesToBuffer(byte[] buffer, short number, int indexBuffer)
        {
            buffer[indexBuffer] = (byte)(number >> 8);
            buffer[indexBuffer + 1] = (byte)(number);
        }

        /// <summary>
        /// Method used to request the content of analog output holding registers. 
        /// </summary>
        /// <param name="buffer">A buffer in which bytes are stored before sending the request</param>
        /// <param name="transactionId">Used to uniquely identify each request</param>
        /// <param name="protocolId">It corresponds to the Modbus protocolId. It always will be 0000</param>
        /// <param name="slaveId">The Slave Address</param>
        /// <param name="functionCode"> The Function Code 3</param>
        /// <param name="dataAddress">The Data Address of the first register requested</param>
        /// <param name="dataRegister">The total number of registers requested</param>
        public void ReadHoldingRegisters(byte[] buffer, string transactionId, short protocolId, byte slaveId, byte functionCode, string dataAddress, string dataRegister)
        {
            short transaction = short.Parse(transactionId, NumberStyles.HexNumber);
            
            AddTwoBytesToBuffer(buffer, transaction, (int)RequestStructure.TransactionId); //0
            AddTwoBytesToBuffer(buffer, protocolId, (int)RequestStructure.ProtocolId); //2

            short address = short.Parse(dataAddress, NumberStyles.HexNumber);
            short registers = short.Parse(dataRegister, NumberStyles.HexNumber);
            short lengthOfMessage = (short)(slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length);
            
            AddTwoBytesToBuffer(buffer, lengthOfMessage, (int)RequestStructure.Length); //4
            buffer[(int)RequestStructure.SlaveId] = slaveId; //6
            buffer[(int)RequestStructure.FunctionCode] = functionCode; //7
            AddTwoBytesToBuffer(buffer, address, (int)RequestStructure.DataAddress); //8
            AddTwoBytesToBuffer(buffer, registers, (int)RequestStructure.DataRegisters); //10
        }

        /// <summary>
        /// Method used to write the contents of analog output holding register.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="transactionId"></param>
        /// <param name="protocolId"></param>
        /// <param name="slaveId"></param>
        /// <param name="functionCode"></param>
        /// <param name="dataAddress"></param>
        /// <param name="dataValue"></param>
        public void PresetSingleRegister(byte[] buffer, string transactionId, short protocolId, byte slaveId, byte functionCode, string dataAddress, string dataValue)
        {
            short transaction = short.Parse(transactionId, NumberStyles.HexNumber);

            AddTwoBytesToBuffer(buffer, transaction, (int)RequestStructure.TransactionId);
            AddTwoBytesToBuffer(buffer, protocolId, (int)RequestStructure.ProtocolId);

            short address = short.Parse(dataAddress, NumberStyles.HexNumber);
            short registers = short.Parse(dataValue, NumberStyles.HexNumber);
            short lengthOfMessage = (short)(slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length);
            
            AddTwoBytesToBuffer(buffer, lengthOfMessage, (int)RequestStructure.Length);
            buffer[(int)RequestStructure.SlaveId] = slaveId;
            buffer[(int)RequestStructure.FunctionCode] = functionCode;
            AddTwoBytesToBuffer(buffer, address, (int)RequestStructure.DataAddress);
            AddTwoBytesToBuffer(buffer, registers, (int)RequestStructure.DataRegisters);
        }

        /// <summary>
        /// Method used to write the contents of analog output holding registers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="transactionId"></param>
        /// <param name="protocolId"></param>
        /// <param name="slaveId"></param>
        /// <param name="functionCode"></param>
        /// <param name="dataAddress"></param>
        /// <param name="dataRegisters"></param>
        /// <param name="dataValue"></param>
        public void PresetMultipleRegisters(byte[] buffer, string transactionId, short protocolId, byte slaveId, byte functionCode, string dataAddress, string dataRegisters, string dataValue)
        {
            short address = short.Parse(dataAddress, NumberStyles.HexNumber);
            short registers = short.Parse(dataRegisters, NumberStyles.HexNumber);
            short[] registerValue = dataValue.Split(' ').Select(hex => short.Parse(hex, NumberStyles.HexNumber)).ToArray();
            short lengthOfMessage = (short)(slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length + numberOfBytesToFollow_Length + 2 * registerValue.Length);
            short transaction = short.Parse(transactionId, NumberStyles.HexNumber);

            AddTwoBytesToBuffer(buffer, transaction, (int)RequestStructure.TransactionId);
            AddTwoBytesToBuffer(buffer, protocolId, (int)RequestStructure.ProtocolId);
            AddTwoBytesToBuffer(buffer, lengthOfMessage, (int)RequestStructure.Length);
            buffer[(int)RequestStructure.SlaveId] = slaveId;
            buffer[(int)RequestStructure.FunctionCode] = functionCode;
            AddTwoBytesToBuffer(buffer, address, (int)RequestStructure.DataAddress);
            AddTwoBytesToBuffer(buffer, registers, (int)RequestStructure.DataRegisters);

            int indexOfFirstRegisterValue = (int)RequestStructure.FirstRegisterValue;
            byte bytesCounter = 0;
            foreach (short element in registerValue)
            {
                AddTwoBytesToBuffer(buffer, element, indexOfFirstRegisterValue);
                indexOfFirstRegisterValue += 2;
                bytesCounter += 2;
            }

            buffer[(int)RequestStructure.NumberOfBytesToFollow] = bytesCounter;
        }
    }
}
