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
        while (true) {
            if (this.mySerial.BytesToRead >= numArray.Length)
            {
              this.mySerial.Read(numArray, 0, numArray.Length);
            }
        }
        serialPort.Close();
        for (int j = 0; j < 10; j++) {
            Console.WriteLine(numArray[j]);
        }
    }
}
