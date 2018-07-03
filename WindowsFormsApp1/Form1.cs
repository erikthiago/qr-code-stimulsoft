using Stimulsoft.Report;
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

        private void button1_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report = rltQrCode;

            report.Dictionary.Variables["Link"].Value = "https://visualstudio.microsoft.com/pt-br/";
            report.Show();
        }
    }
}
