namespace Mail_Sender;

partial class Form1
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
        btnEnviaEmail = new Button();
        txtEmailRemetente = new TextBox();
        gpInfos = new GroupBox();
        gpDestinatario = new GroupBox();
        lblAssunto = new Label();
        txtCorpo = new RichTextBox();
        txtAssunto = new TextBox();
        label1 = new Label();
        txtEmailDest = new TextBox();
        lblSenhaRemetente = new Label();
        txtSenhaRemetente = new TextBox();
        lblEmailRemetente = new Label();
        gpInfos.SuspendLayout();
        gpDestinatario.SuspendLayout();
        SuspendLayout();
        // 
        // btnEnviaEmail
        // 
        btnEnviaEmail.Dock = DockStyle.Bottom;
        btnEnviaEmail.Location = new Point(0, 378);
        btnEnviaEmail.Margin = new Padding(10);
        btnEnviaEmail.Name = "btnEnviaEmail";
        btnEnviaEmail.Size = new Size(765, 59);
        btnEnviaEmail.TabIndex = 6;
        btnEnviaEmail.Text = "&Enviar Email";
        btnEnviaEmail.UseVisualStyleBackColor = true;
        btnEnviaEmail.Click += btnEnviaEmail_Click;
        // 
        // txtEmailRemetente
        // 
        txtEmailRemetente.BorderStyle = BorderStyle.FixedSingle;
        txtEmailRemetente.Location = new Point(93, 17);
        txtEmailRemetente.Name = "txtEmailRemetente";
        txtEmailRemetente.Size = new Size(666, 23);
        txtEmailRemetente.TabIndex = 1;
        // 
        // gpInfos
        // 
        gpInfos.Controls.Add(gpDestinatario);
        gpInfos.Controls.Add(lblSenhaRemetente);
        gpInfos.Controls.Add(txtSenhaRemetente);
        gpInfos.Controls.Add(lblEmailRemetente);
        gpInfos.Controls.Add(txtEmailRemetente);
        gpInfos.Dock = DockStyle.Fill;
        gpInfos.Font = new Font("Segoe UI", 9F);
        gpInfos.Location = new Point(0, 0);
        gpInfos.Name = "gpInfos";
        gpInfos.Size = new Size(765, 378);
        gpInfos.TabIndex = 2;
        gpInfos.TabStop = false;
        gpInfos.Text = "Remente (Outlook):";
        // 
        // gpDestinatario
        // 
        gpDestinatario.Controls.Add(lblAssunto);
        gpDestinatario.Controls.Add(txtCorpo);
        gpDestinatario.Controls.Add(txtAssunto);
        gpDestinatario.Controls.Add(label1);
        gpDestinatario.Controls.Add(txtEmailDest);
        gpDestinatario.Dock = DockStyle.Bottom;
        gpDestinatario.Location = new Point(3, 88);
        gpDestinatario.Name = "gpDestinatario";
        gpDestinatario.Size = new Size(759, 287);
        gpDestinatario.TabIndex = 5;
        gpDestinatario.TabStop = false;
        gpDestinatario.Text = "Destinatário";
        // 
        // lblAssunto
        // 
        lblAssunto.AutoSize = true;
        lblAssunto.Location = new Point(9, 53);
        lblAssunto.Name = "lblAssunto";
        lblAssunto.Size = new Size(53, 15);
        lblAssunto.TabIndex = 8;
        lblAssunto.Text = "Assunto:";
        // 
        // txtCorpo
        // 
        txtCorpo.BorderStyle = BorderStyle.FixedSingle;
        txtCorpo.Location = new Point(6, 80);
        txtCorpo.Name = "txtCorpo";
        txtCorpo.Size = new Size(750, 201);
        txtCorpo.TabIndex = 5;
        txtCorpo.Text = "";
        // 
        // txtAssunto
        // 
        txtAssunto.BorderStyle = BorderStyle.FixedSingle;
        txtAssunto.ForeColor = SystemColors.WindowText;
        txtAssunto.Location = new Point(90, 51);
        txtAssunto.Name = "txtAssunto";
        txtAssunto.Size = new Size(666, 23);
        txtAssunto.TabIndex = 4;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(9, 24);
        label1.Name = "label1";
        label1.Size = new Size(39, 15);
        label1.TabIndex = 7;
        label1.Text = "Email:";
        // 
        // txtEmailDest
        // 
        txtEmailDest.BorderStyle = BorderStyle.FixedSingle;
        txtEmailDest.Location = new Point(90, 22);
        txtEmailDest.Name = "txtEmailDest";
        txtEmailDest.Size = new Size(666, 23);
        txtEmailDest.TabIndex = 3;
        // 
        // lblSenhaRemetente
        // 
        lblSenhaRemetente.AutoSize = true;
        lblSenhaRemetente.Location = new Point(12, 48);
        lblSenhaRemetente.Name = "lblSenhaRemetente";
        lblSenhaRemetente.Size = new Size(42, 15);
        lblSenhaRemetente.TabIndex = 4;
        lblSenhaRemetente.Text = "Senha:";
        // 
        // txtSenhaRemetente
        // 
        txtSenhaRemetente.BorderStyle = BorderStyle.FixedSingle;
        txtSenhaRemetente.Location = new Point(93, 46);
        txtSenhaRemetente.Name = "txtSenhaRemetente";
        txtSenhaRemetente.Size = new Size(666, 23);
        txtSenhaRemetente.TabIndex = 2;
        // 
        // lblEmailRemetente
        // 
        lblEmailRemetente.AutoSize = true;
        lblEmailRemetente.Location = new Point(12, 19);
        lblEmailRemetente.Name = "lblEmailRemetente";
        lblEmailRemetente.Size = new Size(39, 15);
        lblEmailRemetente.TabIndex = 2;
        lblEmailRemetente.Text = "Email:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(765, 437);
        Controls.Add(gpInfos);
        Controls.Add(btnEnviaEmail);
        Name = "Form1";
        Text = "Form1";
        gpInfos.ResumeLayout(false);
        gpInfos.PerformLayout();
        gpDestinatario.ResumeLayout(false);
        gpDestinatario.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnEnviaEmail;
    private TextBox txtEmailRemetente;
    private GroupBox gpInfos;
    private GroupBox gpDestinatario;
    private Label lblSenhaRemetente;
    private TextBox txtSenhaRemetente;
    private Label lblEmailRemetente;
    private RichTextBox txtCorpo;
    private TextBox txtAssunto;
    private Label label1;
    private TextBox txtEmailDest;
    private Label lblAssunto;
}
