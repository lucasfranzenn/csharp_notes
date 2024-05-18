namespace Bate_Papo_Online
{
    partial class frmBatePapo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gboxMensagens = new GroupBox();
            btnEnviarMensagem = new Button();
            txtPortaDestino = new TextBox();
            label4 = new Label();
            txtIpDestino = new TextBox();
            label3 = new Label();
            txtMensagem = new RichTextBox();
            label2 = new Label();
            txtChat = new RichTextBox();
            txtNomeUsuario = new TextBox();
            label1 = new Label();
            gboxConfiguracoesServidor = new GroupBox();
            btnSalvarConfiguracoes = new Button();
            txtPortaServidor = new TextBox();
            label6 = new Label();
            gboxMensagens.SuspendLayout();
            gboxConfiguracoesServidor.SuspendLayout();
            SuspendLayout();
            // 
            // gboxMensagens
            // 
            gboxMensagens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gboxMensagens.Controls.Add(btnEnviarMensagem);
            gboxMensagens.Controls.Add(txtPortaDestino);
            gboxMensagens.Controls.Add(label4);
            gboxMensagens.Controls.Add(txtIpDestino);
            gboxMensagens.Controls.Add(label3);
            gboxMensagens.Controls.Add(txtMensagem);
            gboxMensagens.Controls.Add(label2);
            gboxMensagens.Controls.Add(txtChat);
            gboxMensagens.Controls.Add(txtNomeUsuario);
            gboxMensagens.Controls.Add(label1);
            gboxMensagens.Location = new Point(17, 11);
            gboxMensagens.Name = "gboxMensagens";
            gboxMensagens.Size = new Size(496, 409);
            gboxMensagens.TabIndex = 0;
            gboxMensagens.TabStop = false;
            gboxMensagens.Text = "Mensagens";
            // 
            // btnEnviarMensagem
            // 
            btnEnviarMensagem.FlatStyle = FlatStyle.Popup;
            btnEnviarMensagem.Location = new Point(11, 326);
            btnEnviarMensagem.Name = "btnEnviarMensagem";
            btnEnviarMensagem.Size = new Size(479, 53);
            btnEnviarMensagem.TabIndex = 9;
            btnEnviarMensagem.Text = "&Enviar Mensagem";
            btnEnviarMensagem.UseVisualStyleBackColor = true;
            btnEnviarMensagem.Click += btnEnviarMensagem_Click;
            // 
            // txtPortaDestino
            // 
            txtPortaDestino.BorderStyle = BorderStyle.FixedSingle;
            txtPortaDestino.Location = new Point(373, 298);
            txtPortaDestino.Name = "txtPortaDestino";
            txtPortaDestino.Size = new Size(116, 23);
            txtPortaDestino.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 300);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 7;
            label4.Text = "Porta contato:";
            // 
            // txtIpDestino
            // 
            txtIpDestino.BorderStyle = BorderStyle.FixedSingle;
            txtIpDestino.Location = new Point(108, 298);
            txtIpDestino.Name = "txtIpDestino";
            txtIpDestino.Size = new Size(171, 23);
            txtIpDestino.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 300);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "IP do contato:";
            // 
            // txtMensagem
            // 
            txtMensagem.BorderStyle = BorderStyle.FixedSingle;
            txtMensagem.Location = new Point(161, 237);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(329, 48);
            txtMensagem.TabIndex = 4;
            txtMensagem.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 244);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 3;
            label2.Text = "Mensagens para enviar:";
            // 
            // txtChat
            // 
            txtChat.BorderStyle = BorderStyle.FixedSingle;
            txtChat.Enabled = false;
            txtChat.Location = new Point(17, 56);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(473, 175);
            txtChat.TabIndex = 2;
            txtChat.Text = "";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNomeUsuario.Location = new Point(108, 27);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(382, 23);
            txtNomeUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome usuário:";
            // 
            // gboxConfiguracoesServidor
            // 
            gboxConfiguracoesServidor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gboxConfiguracoesServidor.Controls.Add(btnSalvarConfiguracoes);
            gboxConfiguracoesServidor.Controls.Add(txtPortaServidor);
            gboxConfiguracoesServidor.Controls.Add(label6);
            gboxConfiguracoesServidor.Location = new Point(17, 402);
            gboxConfiguracoesServidor.Name = "gboxConfiguracoesServidor";
            gboxConfiguracoesServidor.Size = new Size(496, 114);
            gboxConfiguracoesServidor.TabIndex = 1;
            gboxConfiguracoesServidor.TabStop = false;
            gboxConfiguracoesServidor.Text = "Configurações do Servidor";
            // 
            // btnSalvarConfiguracoes
            // 
            btnSalvarConfiguracoes.FlatStyle = FlatStyle.Popup;
            btnSalvarConfiguracoes.Location = new Point(10, 51);
            btnSalvarConfiguracoes.Name = "btnSalvarConfiguracoes";
            btnSalvarConfiguracoes.Size = new Size(479, 53);
            btnSalvarConfiguracoes.TabIndex = 11;
            btnSalvarConfiguracoes.Text = "&Aplicar Configurações";
            btnSalvarConfiguracoes.UseVisualStyleBackColor = true;
            btnSalvarConfiguracoes.Click += btnSalvarConfiguracoes_Click;
            // 
            // txtPortaServidor
            // 
            txtPortaServidor.BorderStyle = BorderStyle.FixedSingle;
            txtPortaServidor.Location = new Point(117, 22);
            txtPortaServidor.Name = "txtPortaServidor";
            txtPortaServidor.Size = new Size(372, 23);
            txtPortaServidor.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 24);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 10;
            label6.Text = "Porta do servidor:";
            // 
            // frmBatePapo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 536);
            Controls.Add(gboxConfiguracoesServidor);
            Controls.Add(gboxMensagens);
            MaximumSize = new Size(539, 575);
            MinimizeBox = false;
            MinimumSize = new Size(539, 575);
            Name = "frmBatePapo";
            Text = "Bate Papo - Usuário:";
            FormClosing += frmBatePapo_FormClosing;
            gboxMensagens.ResumeLayout(false);
            gboxMensagens.PerformLayout();
            gboxConfiguracoesServidor.ResumeLayout(false);
            gboxConfiguracoesServidor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxMensagens;
        private GroupBox gboxConfiguracoesServidor;
        private TextBox txtNomeUsuario;
        private Label label1;
        private Button btnEnviarMensagem;
        private TextBox txtPortaDestino;
        private Label label4;
        private TextBox txtIpDestino;
        private Label label3;
        private RichTextBox txtMensagem;
        private Label label2;
        private RichTextBox txtChat;
        private TextBox txtPortaServidor;
        private Label label6;
        private Button btnSalvarConfiguracoes;
    }
}
