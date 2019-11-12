using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instance almak, yeni bir örnek alma.
            FirstClass fc1 = new FirstClass();
            fc1.Ad = "Oğuzhan";
            fc1.SoyAd = "Tomak";
            fc1.Yas = 20;

            label1.Text = fc1.Ad;
            label2.Text = fc1.SoyAd;
        }
    }
}
