using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPA
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
        }
        int toplam=0;
        private void btnAddition_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtIslem.Text);
            toplam += num1;
            txtIslem.Text = toplam.ToString();
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtIslem.Text);
            toplam -= num1;
            txtIslem.Text = toplam.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtIslem.Text);
            toplam *= num1;
            txtIslem.Text = toplam.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            
            int num1 = Convert.ToInt32(txtIslem.Text);
            if(num1==0)
            {
                MessageBox.Show("Sayıyı 0 a bölemezsiniz");
            }
            else
            {
                toplam /= num1;
                txtIslem.Text = toplam.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            toplam = 0;
            MessageBox.Show("Toplam 0 a eşitlendi");
        }
    }
}
