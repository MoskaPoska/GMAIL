using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace GMAIL
{
    public partial class Form1 : Form
    {
        List<string>? AttachFile = null;
        MailMessage? message = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttachFile = new List<string>();
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                AttachFile.Add(file.FileName);
                listBox1.Items.Add(file.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string google = "smtp.gmail.com";
            message = new MailMessage(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text);
            SmtpClient client = new SmtpClient(google);
            client.Port = 587;
            client.Credentials = new NetworkCredential("buralevartem@gmail.com", "emmjdhfcivmveqhz");
            client.EnableSsl = true;
            if (AttachFile != null)
            {
                for (int i = 0; i < AttachFile.Count; i++)
                {
                    Attachment attach = new Attachment(AttachFile[i]);
                    message.Attachments.Add(attach);
                }
            }
            try
            {
                client.SendAsync(message, "Вот и сказочке конец");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            MessageBox.Show("Мистер Пропер, всегда поможет");
        }
    }
}