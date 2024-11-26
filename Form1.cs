using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client_Example
{
    public partial class Form1 : Form
    {
        private TcpClient client; // TCP Client nesnesi
        private NetworkStream stream; // Veri ak��� i�in

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = txtIP.Text; // IP adresini al
                int port = int.Parse(txtPort.Text); // Port numaras�n� al

                // TCP Client ba�lant�s�n� ba�lat
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();

                txtReceived.AppendText("Ba�lant� ba�ar�l�!\n");

                // Gelen mesajlar� dinlemek i�in StartListening metodu �a�r�l�r
                Task.Run(() => StartListening());
            }
            catch (Exception ex)
            {
                txtReceived.AppendText("\nBa�lant� hatas�: " + ex.Message + "\n");
            }

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    // Kullan�c�n�n yazd��� mesaj� al
                    string message = txtMessage.Text;

                    // Mesaj� TCP ba�lant�s� �zerinden g�nder
                    byte[] data = Encoding.UTF8.GetBytes(message + "\n"); // SCPI uyumu i�in '\n' eklenir
                    stream.Write(data, 0, data.Length);

                    txtReceived.AppendText("\nG�nderilen mesaj: " + message + "\n");
                }
                else
                {
                    txtReceived.AppendText("\nBa�lant� kurulmad�!\n");
                }
            }
            catch (Exception ex)
            {
                txtReceived.AppendText("G�nderim hatas�: " + ex.Message + "\n");
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Ba�lant�y� kapat
                if (client != null)
                {
                    stream.Close();
                    client.Close();
                    client = null;

                    txtReceived.AppendText("Ba�lant� kapat�ld�.\n");
                }
            }
            catch (Exception ex)
            {
                txtReceived.AppendText("Ba�lant� kapatma hatas�: " + ex.Message + "\n");
            }
        }
        // Gelen Mesajlar� Dinleme Metodu
        private async void StartListening()
        {
            byte[] buffer = new byte[1024];

            while (client != null && client.Connected)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Gelen mesaj� kullan�c�ya g�ster
                    txtReceived.Invoke(new Action(() => txtReceived.AppendText("Gelen mesaj: " + response + "\n")));
                }
                catch (Exception ex)
                {
                    txtReceived.Invoke(new Action(() => txtReceived.AppendText("Dinleme hatas�: " + ex.Message + "\n")));
                    break;
                }
            }
        }
    }
}
