using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client_Example
{
    public partial class Form1 : Form
    {
        private TcpClient client; // TCP Client nesnesi
        private NetworkStream stream; // Veri akýþý için

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
                int port = int.Parse(txtPort.Text); // Port numarasýný al

                // TCP Client baðlantýsýný baþlat
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();

                txtReceived.AppendText("Baðlantý baþarýlý!\n");

                // Gelen mesajlarý dinlemek için StartListening metodu çaðrýlýr
                Task.Run(() => StartListening());
            }
            catch (Exception ex)
            {
                txtReceived.AppendText("\nBaðlantý hatasý: " + ex.Message + "\n");
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
                    // Kullanýcýnýn yazdýðý mesajý al
                    string message = txtMessage.Text;

                    // Mesajý TCP baðlantýsý üzerinden gönder
                    byte[] data = Encoding.UTF8.GetBytes(message + "\n"); // SCPI uyumu için '\n' eklenir
                    stream.Write(data, 0, data.Length);

                    txtReceived.AppendText("\nGönderilen mesaj: " + message + "\n");
                }
                else
                {
                    txtReceived.AppendText("\nBaðlantý kurulmadý!\n");
                }
            }
            catch (Exception ex)
            {
                txtReceived.AppendText("Gönderim hatasý: " + ex.Message + "\n");
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Baðlantýyý kapat
                if (client != null)
                {
                    stream.Close();
                    client.Close();
                    client = null;

                    txtReceived.AppendText("Baðlantý kapatýldý.\n");
                }
            }
            catch (Exception ex)
            {
                txtReceived.AppendText("Baðlantý kapatma hatasý: " + ex.Message + "\n");
            }
        }
        // Gelen Mesajlarý Dinleme Metodu
        private async void StartListening()
        {
            byte[] buffer = new byte[1024];

            while (client != null && client.Connected)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Gelen mesajý kullanýcýya göster
                    txtReceived.Invoke(new Action(() => txtReceived.AppendText("Gelen mesaj: " + response + "\n")));
                }
                catch (Exception ex)
                {
                    txtReceived.Invoke(new Action(() => txtReceived.AppendText("Dinleme hatasý: " + ex.Message + "\n")));
                    break;
                }
            }
        }
    }
}
