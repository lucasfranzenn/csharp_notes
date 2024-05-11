using System.Net;
using System.Net.Mail;

namespace Mail_Sender;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnEnviaEmail_Click(object sender, EventArgs e)
    {
        SmtpClient smtp = new();

        smtp.Host = "smtp.office365.com";
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

        MailMessage mail = new();
        mail.IsBodyHtml = false;

        try
        {
            smtp.Credentials = new NetworkCredential(txtEmailRemetente.Text.Trim(), txtSenhaRemetente.Text.Trim());

            mail.From = new MailAddress(txtEmailRemetente.Text.Trim());
            mail.To.Add(new MailAddress(txtEmailDest.Text));

            mail.Subject = txtAssunto.Text;
            mail.Body = txtCorpo.Text;

            smtp.Send(mail);

            MessageBox.Show("Email enviado com sucesso");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }
}
