using System;
using System.Windows;
using System.IO.Ports;
using System.Threading;
using LTOKiosk.Views;

namespace LTOKiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static bool _continue;
        static SerialPort _serialPort;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new TransactionView();
        
        }


        private void connectSerialPort() {

            string name;
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = "COM2";// SetPortName(_serialPort.PortName);
            _serialPort.BaudRate = 19200;// SetPortBaudRate(_serialPort.BaudRate);
            _serialPort.DataBits = 8;// SetPortDataBits(_serialPort.DataBits);
            _serialPort.Handshake = Handshake.None;// SetPortHandshake(_serialPort.Handshake);
            _serialPort.DtrEnable = true;
            _serialPort.RtsEnable = true;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
            _serialPort.Open();
            readThread.Start();
            // _serialPort.Close();
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    System.Diagnostics.Debug.WriteLine(message);
                }
                catch (TimeoutException) { }
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connectSerialPort();
        }

        private void Button_Init(object sender, RoutedEventArgs e)
        {
            if (_serialPort.IsOpen) {

                _serialPort.Write(_serialPort.ReadExisting() + "CIM_PrepareDeposit");

            }
        }


        // delegate is used to write to a UI control from a non-UI thread
        private delegate void SetTextDeleg(string text);

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            string data = _serialPort.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.  
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  
            Dispatcher.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
         

        }

        private void si_DataReceived(string data) {
            System.Diagnostics.Debug.WriteLine(data.Trim());
        }
    }
}
