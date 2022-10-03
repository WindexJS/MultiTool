using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private void Translator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Normalize();
            var toLanguage = textBox2.Text;
            var fromLanguage = textBox3.Text;
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={toLanguage}&tl={fromLanguage}&dt=t&q={input}";
            var webClient = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                textBox1.Text = result;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
