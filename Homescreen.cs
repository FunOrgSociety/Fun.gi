using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Homescreen : Form
    {
        public Homescreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Logscreen logscreen = new Logscreen();
            this.Hide();
            logscreen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();

        }
    }
}
