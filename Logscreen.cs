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
    public partial class Logscreen : Form
    {
        public Logscreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox2.Text=="user" )
            {

                Homescreen homescreen = new Homescreen();
                this.Hide();
                homescreen.ShowDialog();



            }
            else {
                Form1 form = new Form1();
                form.ShowDialog();
            }
        
            
        }
    }
}
