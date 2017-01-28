using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using elton.host;
using elton.proxy;

namespace elton.apresentacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proxy p = new Proxy();
            MessageBox.Show(p.GetFriendlyGreeting(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proxy p = new Proxy();
            MessageBox.Show(p.GetRudeGreeting(textBox1.Text));
        }
    }
}
