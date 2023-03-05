using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMOD3_1302210104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Mebuat String yang diambil dari InputBox
            string input = InputBox.Text;
            //Mengirimkan Output teks yang diambil dari InputBox
            OutputBoxes.Text = "Halo "+input;
        }
        private void InputBox_TextChanged_1(object sender, EventArgs e)
        {
            //BoxInput
        }

        private void OutputBoxes_TextChanged(object sender, EventArgs e)
        {
            //BoxOutput
        }
    }
}
