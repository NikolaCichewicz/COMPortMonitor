using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;

namespace COMPort___Monitor
{
    public partial class COMPort : Form
    {
        FormWindowState formState = new FormWindowState();
        SerialPort serial_port = new SerialPort();

        String saveFile = null;
        FileStream saveFileStream = null;

        public COMPort()
        {
            InitializeComponent();
        }

        private void COM_Port()
        {
            string[] my_string = SerialPort.GetPortNames();
            if (my_string == null)
            {
                MessageBox.Show("The serial port cannot be opened, please check whether the serial port is connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* Port number */
            foreach (string str in my_string)
            {
                port_cb.Items.Add(str);
            }
            if (port_cb.Items.Count > 0)
            {
                
                port_cb.SelectedIndex = 0;
            }
             


            /* Baud rate */
            string[] baud_rate = { "2400", "4800","9600", "19200", "38400", "57600", "115200" };
            foreach (string str in baud_rate)
            {
                baudrate_cb.Items.Add(str);
            }
            baudrate_cb.SelectedIndex = 0;

            /* Parity */
            string[] parity = { "None", "Odd", "Even", "Mark", "Space" };
            foreach (string str in parity)
            {
                parity_cb.Items.Add(str);
            }
            parity_cb.SelectedIndex = 0;


            /* Data bits */
            string[] data_bits = { "5", "6", "7", "8" };
            foreach (string str in data_bits)
            {
                databits_cb.Items.Add(str);
            }
            databits_cb.SelectedIndex = 0;


            /* Stop bits */
            string[] stop_bits = { "1", "1.5", "2" };
            foreach (string str in stop_bits)
            {
                stopbits_cb.Items.Add(str);
            }
            stopbits_cb.SelectedIndex = 0;
        }

            public void SaveAsFile()
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Txt |*.txt";
                saveFileDialog.Title = "COMPort data";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != null)
                {
                saveFile = saveFileDialog.FileName;
                }
            }
        
            private void Dashboard_Load(object sender, EventArgs e)
        {
            COM_Port();

            Control.CheckForIllegalCrossThreadCalls = false;
            serial_port.DataReceived += new SerialDataReceivedEventHandler(Data_Received);

            /* Kontrola przepływu */
            serial_port.DtrEnable = true; // Data Terminal Read
            serial_port.RtsEnable = true; // Request to Send

            serial_port.ReadTimeout = 1000;

            serial_port.Close();
        }

        DateTime date_time_now = DateTime.Now;
        String data = "";

        public void Data_Received(object sender, SerialDataReceivedEventArgs e)
        {
            if (serial_port.IsOpen)
            {

                textBox.Text += string.Format("{0}\r\n", date_time_now);
                textBox.ForeColor = Color.Gray;

                try
                {
                    String data = serial_port.ReadLine();
                    textBox.Text += data + "\r\n";

                    if (saveFileStream != null)
                    {
                        byte[] datasave = new UTF8Encoding(true).GetBytes(data + "\r\n");
                        saveFileStream.Write(datasave, 0, datasave.Length);
                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                textBox.SelectionStart = textBox.TextLength;
                textBox.ScrollToCaret();
               // serial_port.DiscardInBuffer();
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (!serial_port.IsOpen)
            {
                try
                {
                    if (port_cb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Invalid port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string port_string = port_cb.SelectedItem.ToString();
                    string baudrate_string = baudrate_cb.SelectedItem.ToString();
                    string databits_string = databits_cb.SelectedItem.ToString();
                    string parity_string = parity_cb.SelectedItem.ToString();
                    string stopbits_string = stopbits_cb.SelectedItem.ToString();

                    Int32 baudrate_converted = Convert.ToInt32(baudrate_string);
                    Int32 databits_converted = Convert.ToInt32(databits_string);

                    serial_port.PortName = port_string;
                    serial_port.BaudRate = baudrate_converted;
                    serial_port.DataBits = databits_converted;

                    switch (stopbits_string)
                    {
                        case "None": serial_port.StopBits = StopBits.None; break;
                        case "1": serial_port.StopBits = StopBits.One; break;
                        case "1.5": serial_port.StopBits = StopBits.OnePointFive; break;
                        case "2": serial_port.StopBits = StopBits.Two; break;
                        default: MessageBox.Show("Incorrect stop bits parameter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }

                    switch (parity_string)
                    {
                        case "None": serial_port.Parity = Parity.None; break;
                        case "Odd": serial_port.Parity = Parity.Odd; break;
                        case "Even": serial_port.Parity = Parity.Even; break;
                        case "Mark": serial_port.Parity = Parity.Mark; break;
                        case "Space": serial_port.Parity = Parity.Space; break;
                        default: MessageBox.Show("Incorrect parity parameter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }

                    if(saveFile != null)
                    {
                        saveFileStream = File.Create(saveFile);
                    }

                    serial_port.Open();

                    port_cb.Enabled = false;
                    parity_cb.Enabled = false;
                    stopbits_cb.Enabled = false;
                    databits_cb.Enabled = false;
                    baudrate_cb.Enabled = false;
                    start_btn.Enabled = false;
                    stop_btn.Enabled = true;
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (saveFileStream != null)
                {
                    saveFileStream.Close();
                    saveFileStream = null;
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox.Text = ""; // textBox.Clear()
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            serial_port.Close();

            port_cb.Enabled = true;
            parity_cb.Enabled = true;
            stopbits_cb.Enabled = true;
            databits_cb.Enabled = true;
            baudrate_cb.Enabled = true;
            start_btn.Enabled = true;
            stop_btn.Enabled = false;
        }

        string connectionstring = @"Data Source=NIKOLA-DELL;Initial Catalog=COMPortDb;Integrated Security=True";


        private void exitprogram_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Are you sure?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK);
            System.Windows.Forms.Application.Exit();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void save_file_btn_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        public void save_db_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                String query = "INSERT INTO dbo.COMPort_RD (ReceivedData, Time) VALUES (@ReceivedData, @Time)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReceivedData", data);
                    command.Parameters.AddWithValue("@Time", date_time_now);

                    connection.Open();
                    var result = command.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error with inserting data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
