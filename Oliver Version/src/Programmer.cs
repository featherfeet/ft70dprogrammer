using System;
using System.IO.Ports;

public class Programmer {
    static public void Main(string[] args) {
        // Load default file.
        Database database = new Database();
        DefaultFile defaultFile = new DefaultFile();
        defaultFile.LoadFromDefaultFile();
        database.Buffer = defaultFile.DefaultBuffer;
        database.Decode();
        // Create and open serial port and receiving protocol.
        SerialPort serialPort = new SerialPort("/dev/ttyACM0");
        SerialProtocol serialProtocol = new SerialProtocol(serialPort, database, false);
        serialProtocol.PortOpen();
        // Read in data from radio.
        Console.WriteLine("With the radio in ADMS mode (see manual), press the BAND button on the top-right corner of the buttons.");
        serialProtocol.Run();
    }
}
