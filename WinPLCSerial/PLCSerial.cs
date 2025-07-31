using System.IO.Ports;

namespace WinPLCSerial {
    public partial class PLCSerial : Form {
        SerialPort serialPort;
        public PLCSerial() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void printOutput(string text) {
            String dateTime = DateTime.Now.ToString();
            this.outputBox.Text += $"{dateTime} {text}\r\n";
        }

        private void openPortButton_click(object sender, EventArgs e) {
            string port = this.portNameComboBox.Text;
            int baudrate = int.Parse(this.baudRateComboBox.Text);
            int databits = int.Parse(this.dataBitsComboBox.Text);
            StopBits stopBits = (StopBits) int.Parse(this.stopBitsComboBox.Text);
            string parityText = this.parityComboBox.Text;
            Parity parity = (Parity) Enum.Parse(typeof(Parity), parityText);
            int timeout = int.Parse(this.timeoutEntry.Text);

            this.serialPort = new SerialPort(port, baudrate, parity, databits, stopBits);
            this.serialPort.ReadTimeout = timeout;
            try {
                this.serialPort.Open();
                openPortButton.Enabled = false;
                closePortButton.Enabled = true;
                printOutput($"Opened port {port}");

            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex);
                printOutput("Failed to open port");
            }

        }

        private void closePortButton_click(object sender, EventArgs e) {
            try {
                this.serialPort.Close();
                closePortButton.Enabled = false;
                openPortButton.Enabled = true;
                printOutput($"Closed port {this.serialPort.PortName}");
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex);
                printOutput($"Failed to close port {this.serialPort.PortName}");
            }
        }

        private void clearButton_click(object sender, EventArgs e) {
            this.outputBox.Text = "";
        }

        private void commandEntry_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {
                if (this.serialPort == null || !this.serialPort.IsOpen) {
                    return;
                }
                string command = this.commandEntry.Text;
                printOutput($"Sending command {command}");
                this.serialPort.Write(command + "\r\n");
                string response = this.serialPort.ReadTo("\r");
                printOutput($"Response: {response}");
            }
        }
    }
}
