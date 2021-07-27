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
    public enum Operators { Add, Sub, Multi, Div }

    public partial class calculator : Form
    {
        public int res = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public calculator()
        {
            InitializeComponent();
        }

        private void numBt1_Click(object sender, EventArgs e)
        {
            Button numBt = (Button)sender;
            setNum(numBt.Text);
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

        private void plusBt_Click(object sender, EventArgs e)
        {
            if(isNewNum == false)
            {
                int nowNum = int.Parse(resultBox.Text);
                if(Opt == Operators.Add)
                    res += nowNum;
                else if(Opt == Operators.Sub)
                    res -= nowNum;
                else if (Opt == Operators.Multi)
                    res *= nowNum;
                else if (Opt == Operators.Div)
                    res /= nowNum;

                resultBox.Text = res.ToString();
                isNewNum = true;
            }


            Button optButton = (Button)sender;
            if(optButton.Text == "+")
                Opt = Operators.Add;
            else if(optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "×")
                Opt = Operators.Multi;
            else if (optButton.Text == "÷")
                Opt = Operators.Div;
        }

        private void clearNum_Click(object sender, EventArgs e)
        {
            res = 0;
            isNewNum = true;
            Opt = Operators.Add;

            resultBox.Text = "0";
        }

       
        private void sourceLink_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/swim0413/calculator");
                sourceLink.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
