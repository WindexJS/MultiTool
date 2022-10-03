using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Chat : Form
    {
        private static void send(string s, string p)
        {
            File.WriteAllText(p, s + "\n" + (int.Parse(File.ReadAllLines(p)[1]) + 1));
        }

        public Chat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "S:\\Chat\\Sessions\\";
            string path = textBox1.Text;
            string text2 = Path.Combine(text, path);
            Directory.CreateDirectory(text);
            if (!File.Exists(text2))
            {
                File.Create(text2);
                File.WriteAllText(text2, "\n0");
            }
            send(textBox2.Text, text2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }
    }
}
