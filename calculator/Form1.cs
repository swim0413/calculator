using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public int res = 0;
        public bool isNewNum = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void numBt1_Click(object sender, EventArgs e)
        {
            setNum("1");
        }

        public void setNum(string num)
        {
            if (isNewNum)
            {
                resultBox.Text = num;
                isNewNum = false;
            }
            else if (resultBox.Text == "0")
            {
                resultBox.Text = num;
            }
            else
            {
                resultBox.Text += num;
            }
        }

        private void numBt2_Click(object sender, EventArgs e)
        {
            setNum("2");
        }

        private void plusBt_Click(object sender, EventArgs e)
        {
            int nowNum = int.Parse(resultBox.Text);
            res += nowNum;
            resultBox.Text = res.ToString();
            isNewNum = true;
        }
    }
}
