using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Bate_Papo_Online
{
    public partial class frmBatePapo : Form
    {
        TcpListener? _host = null;
        TcpClient? _client = null;
        Thread? _serverThread = null;
        bool stopServer = false;

        public frmBatePapo()
        {
            InitializeComponent();
        }

        private void btnSalvarConfiguracoes_Click(object sender, EventArgs e)
        {
            if (Utils.ValidaTextoConfig(txtNomeUsuario, txtPortaServidor))
            {
                Utils.Mensagem("Preencha os campos de usuário e porta do servidor!", 2);
                return;
            }
            Text = "Bate Papo - Usuário: " + txtNomeUsuario.Text;

            PararServidor();

            _serverThread = new Thread(() =>
            {
                _host = new(IPAddress.Any, Convert.ToInt32(txtPortaServidor.Text));
                _host.Start();

                while (!stopServer)
                {
                    try
                    {
                        _client = _host.AcceptTcpClient();
                        NetworkStream ns = _client.GetStream();

                        byte[] bufferRecebido = new byte[256];
                        int bytesRecebidos = ns.Read(bufferRecebido, 0, bufferRecebido.Length);
                        string mensagemRecebida = Encoding.ASCII.GetString(bufferRecebido, 0, bytesRecebidos);

                        AtualizaChat(mensagemRecebida + "\r\n");
                    }
                    catch (SocketException ex)
                    {
                        if ((SocketError)ex.ErrorCode != SocketError.Interrupted) Utils.Mensagem(ex.Message, 1);
                    }
                    catch (Exception ex)
                    {
                        Utils.Mensagem(ex.Message, 1);
                    }
                }
            });
            _serverThread.Start();

        }

        public void AtualizaChat(string mensagem)
        {
            if (txtChat.InvokeRequired)
                txtChat.Invoke((MethodInvoker)(() => AtualizaChat(mensagem)));
            else
                txtChat.Text += mensagem;
        }

        private void PararServidor()
        {
            try
            {
                stopServer = true;
                if (_host != null)
                {
                    _host.Stop();
                    _host = null;
                }
                if (_client != null)
                {
                    _client.Close();
                    _client = null;
                }

                if (_serverThread != null)
                    _serverThread.Join();

                stopServer = false;
            }
            catch (Exception ex)
            {
                Utils.Mensagem(ex.Message, 1);
                throw;
            }
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient sendClient = new(txtIpDestino.Text, Convert.ToInt32(txtPortaDestino.Text));
                NetworkStream ns = sendClient.GetStream();

                string mensagemEnviada = new(txtNomeUsuario.Text + ": " + txtMensagem.Text);
                byte[] buffer = Encoding.ASCII.GetBytes(mensagemEnviada);
                ns.Write(buffer, 0, buffer.Length);

                sendClient.Close();

                AtualizaChat("* " + mensagemEnviada + "\r\n");
            }
            catch (Exception ex)
            {
                Utils.Mensagem(ex.Message, 1);
            }
        }

        private void frmBatePapo_FormClosing(object sender, FormClosingEventArgs e)
        {
            PararServidor();
        }
    }
}