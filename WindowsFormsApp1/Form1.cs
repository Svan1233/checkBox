using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPosalji_Click(object sender, EventArgs e)
        {

            if (chkSakrij.Checked)
            {

            }
            else
            {
                txtPrikaz.Clear();

                if (chkDorucak.Checked)
                {
                    txtPrikaz.AppendText("Odabrali ste doručak.");
                }
                if (chkRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste ručak.");
                }
                if (chkVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste večeru.");
                }
            }

        }

        private void ChkSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSakrij.Checked)
            {
                if (chkDorucak.Checked)
                {
                    txtPrikaz.AppendText("Odabrali ste doručak.");
                }
                if (chkRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste ručak.");
                }
                if (chkVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste večeru.");
                }
                
            }
            else
            {
                txtPrikaz.Clear();
            }
        }
    }
}
