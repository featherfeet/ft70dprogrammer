using System;
using System.IO.Ports;

public class Testing {
    static public void Main(string[] args) {
        SerialPort serialPort = new SerialPort("/dev/ttyACM0");
        serialPort.BaudRate = 38400;
        serialPort.DataBits = 8;
        serialPort.Parity = Parity.None;
        serialPort.StopBits = StopBits.One;
        serialPort.Handshake = Handshake.None;
        serialPort.Open();
        byte[] numArray = new byte[10];
        int i = 0;
        Int32 byte_read = -1;
        while (i < 10) {
            try {
                byte_read = serialPort.ReadByte();
            }
            catch (System.IO.IOException e) {
            }
            if (byte_read != -1) {
                numArray[i] = (byte) byte_read;
                i++;
            }
        }
        serialPort.Close();
        for (int j = 0; j < 10; j++) {
            Console.WriteLine(numArray[j]);
        }
    }
}
