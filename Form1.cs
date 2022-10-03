using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox10.Text = HardwareInfo.GetBIOScaption();
            textBox1.Text = HardwareInfo.GetProcessorId();
            textBox4.Text = Convert.ToString(HardwareInfo.GetCpuSpeedInGHz()) + " Ghz";
            textBox3.Text = HardwareInfo.GetProcessorInformation();
            textBox8.Text = HardwareInfo.GetPhysicalMemory();
            textBox7.Text = HardwareInfo.GetNoRamSlots();
            textBox6.Text = HardwareInfo.GetBIOSmaker();
            textBox5.Text = HardwareInfo.GetBIOSserNo();
            new ToastContentBuilder().AddArgument("action", "viewConversation").AddArgument("conversationId", 9813).AddText("System Info Loaded!").AddText("The form should now appear on your screen, showing the system info!").AddAppLogoOverride(new Uri("L:/R (5).ico"), ToastGenericAppLogoCrop.Default).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = HardwareInfo.GetProcessorId();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(HardwareInfo.GetCpuSpeedInGHz()) + " Ghz";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = HardwareInfo.GetProcessorInformation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = HardwareInfo.GetPhysicalMemory();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Text = HardwareInfo.GetNoRamSlots();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.Text = HardwareInfo.GetBIOSmaker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = HardwareInfo.GetBIOSserNo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = HardwareInfo.GetBIOScaption();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            this.Hide();
        }
    }
}
