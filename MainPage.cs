using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(210, 0);
            new ToastContentBuilder().AddArgument("action", "viewConversation").AddArgument("conversationId", 9813).AddText("Multitool Menu Loaded!").AddText("The menu should appear on your screen, if not, please reload the program!").AddAppLogoOverride(new Uri("L:/R (5).ico"), ToastGenericAppLogoCrop.Default).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Translator();
            myForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Calculator.Form11();
            myForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myForm = new Wallpaper();
            myForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 1;
            string Time = DateTime.Now.ToString();
            while (count != count + 1)
            {
                textBox1.Text = Time;
                Thread.Sleep(1000);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var myForm = new Chat();
            myForm.Show();
            this.Hide();
        }
    }
}
