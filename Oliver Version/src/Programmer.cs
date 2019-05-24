using System;
using System.Threading;
using System.IO;
using System.IO.Ports;

public class Programmer {
    static public void Main(string[] args) {
        // Load default file.
        Database database = new Database();
        DefaultFile defaultFile = new DefaultFile();
        defaultFile.LoadFromDefaultFile();
        database.Buffer = defaultFile.DefaultBuffer;
        database.Decode();
        // Tell user to physically set up the radio.
        Console.WriteLine("Connect the radio to the computer and put it in ADMS mode, then press ENTER.");
        Console.ReadLine();
        Console.WriteLine("Waiting 30 secs. because that seems to make it more likely that the transfer will not have errors:");
        for (int i = 0; i < 30; i++) {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
        // Create and open serial port and receiving protocol.
        SerialPort serialPort = new SerialPort("/dev/ttyACM0");
        SerialProtocol serialProtocol = new SerialProtocol(serialPort, database, false);
        serialProtocol.PortOpen();
        // Read in data from radio.
        Console.WriteLine("With the radio still in ADMS mode, press the BAND button on the top-right corner of the buttons.");
        serialProtocol.Run();
        // Close connection.
        serialProtocol.PortClose();
        // Decode recieved data.
        database.Decode();
        File.WriteAllBytes("data.db", database.Buffer);
    }
}
