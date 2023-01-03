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
        //--------magic numbers--------//

        enum RequestMessageStructure
        {
            TransactionId = 0,
            ProtocolId = 2,
            Length = 4,
            SlaveId = 6,
            FunctionCode = 7,
            DataAddress = 8,
            DataRegisters = 10,
            NumberOfBytesToFollow = 12,
            FirstValueToWrite = 13
        }

        //-----------------------------//

        public const byte slaveIdLength = 0x01;
        public const byte functionCodeLength = 0x01;
        public const byte firstAddressLength = 0x02;
        public const byte numberOfRegistersLength = 0x02;
        public const byte numberBytesToFollow = 0x01;

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
        /// <param name="transactionText">Used to uniquely identify each request</param>
        /// <param name="protocolId">It corresponds to the Modbus protocol. It always will be 0000</param>
        /// <param name="slaveId">The Slave Address</param>
        /// <param name="functionCode"> The Function Code 3</param>
        /// <param name="firstAddressText">The Data Address of the first register requested</param>
        /// <param name="numberOfRegistersText">The total number of registers requested</param>
        public void ReadHoldingRegisters(byte[] buffer, string transactionText, short protocolId, byte slaveId, byte functionCode, string firstAddressText, string numberOfRegistersText)
        {
            short transactionId = short.Parse(transactionText, NumberStyles.HexNumber);
            AddTwoBytesToBuffer(buffer, transactionId, (int)RequestMessageStructure.TransactionId); //0
            
            AddTwoBytesToBuffer(buffer, protocolId, (int)RequestMessageStructure.ProtocolId); //2

            short firstAddress = short.Parse(firstAddressText, NumberStyles.HexNumber);
            short numberOfRegisters = short.Parse(numberOfRegistersText, NumberStyles.HexNumber);
            
            short lengthOfMessage = (short)(slaveIdLength + functionCodeLength + firstAddressLength + numberOfRegistersLength);
            AddTwoBytesToBuffer(buffer, lengthOfMessage, (int)RequestMessageStructure.Length); //4

            buffer[(int)RequestMessageStructure.SlaveId] = slaveId; //6
            buffer[(int)RequestMessageStructure.FunctionCode] = functionCode; //7
            AddTwoBytesToBuffer(buffer, firstAddress, (int)RequestMessageStructure.DataAddress); //8
            AddTwoBytesToBuffer(buffer, numberOfRegisters, (int)RequestMessageStructure.DataRegisters); //10
        }

        /// <summary>
        /// Method used to write the contents of analog output holding register.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="transactionText"></param>
        /// <param name="protocolId"></param>
        /// <param name="slaveId"></param>
        /// <param name="functionCode"></param>
        /// <param name="firstAddressText"></param>
        /// <param name="registerValueText"></param>
        public void PresetSingleRegister(byte[] buffer, string transactionText, short protocolId, byte slaveId, byte functionCode, string firstAddressText, string registerValueText)
        {
            short transactionId = short.Parse(transactionText, NumberStyles.HexNumber);
            AddTwoBytesToBuffer(buffer, transactionId, (int)RequestMessageStructure.TransactionId);
            AddTwoBytesToBuffer(buffer, protocolId, (int)RequestMessageStructure.ProtocolId);

            short firstAddress = short.Parse(firstAddressText, NumberStyles.HexNumber);
            short registerValue = short.Parse(registerValueText, NumberStyles.HexNumber);

            short lengthOfMessage = (short)(slaveIdLength + functionCodeLength + firstAddressLength + numberOfRegistersLength);
            AddTwoBytesToBuffer(buffer, lengthOfMessage, (int)RequestMessageStructure.Length);
            
            buffer[(int)RequestMessageStructure.SlaveId] = slaveId;
            buffer[(int)RequestMessageStructure.FunctionCode] = functionCode;
            AddTwoBytesToBuffer(buffer, firstAddress, (int)RequestMessageStructure.DataAddress);
            AddTwoBytesToBuffer(buffer, registerValue, (int)RequestMessageStructure.DataRegisters);
        }

        /// <summary>
        /// Method used to write the contents of analog output holding registers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="transactionText"></param>
        /// <param name="protocolId"></param>
        /// <param name="slaveId"></param>
        /// <param name="functionCode"></param>
        /// <param name="firstAddressText"></param>
        /// <param name="numberOfRegistersText"></param>
        /// <param name="registerValueText"></param>
        public void PresetMultipleRegisters(byte[] buffer, string transactionText, short protocolId, byte slaveId, byte functionCode, string firstAddressText, string numberOfRegistersText, string registerValueText)
        {
            short firstAddress = short.Parse(firstAddressText, NumberStyles.HexNumber);
            short numberOfRegisters = short.Parse(numberOfRegistersText, NumberStyles.HexNumber);
            short[] registerValue = registerValueText.Split(' ')
                        .Select(hex => short.Parse(hex, NumberStyles.HexNumber))
                        .ToArray();
            
            short lengthOfMessage16 = (short)(slaveIdLength + functionCodeLength + firstAddressLength + numberOfRegistersLength + numberBytesToFollow + 2 * registerValue.Length);

            short transactionId = short.Parse(transactionText, NumberStyles.HexNumber);

            AddTwoBytesToBuffer(buffer, transactionId, (int)RequestMessageStructure.TransactionId);
            AddTwoBytesToBuffer(buffer, protocolId, (int)RequestMessageStructure.ProtocolId);
            AddTwoBytesToBuffer(buffer, lengthOfMessage16, (int)RequestMessageStructure.Length);
            buffer[(int)RequestMessageStructure.SlaveId] = slaveId;
            buffer[(int)RequestMessageStructure.FunctionCode] = functionCode;
            AddTwoBytesToBuffer(buffer, firstAddress, (int)RequestMessageStructure.DataAddress);
            AddTwoBytesToBuffer(buffer, numberOfRegisters, (int)RequestMessageStructure.DataRegisters);

            int indexOfFirstValue = (int)RequestMessageStructure.FirstValueToWrite;
            byte bytesCounter = 0;
            foreach (short element in registerValue)
            {
                AddTwoBytesToBuffer(buffer, element, indexOfFirstValue);
                indexOfFirstValue += 2;
                bytesCounter += 2;
            }

            buffer[(int)RequestMessageStructure.NumberOfBytesToFollow] = bytesCounter;
        }
    }
}
