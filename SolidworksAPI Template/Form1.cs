using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidworksAPI_Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void swAppStart()
        {
            try
            {
                SldWorks.SldWorks swApp;

                swApp = new SldWorks.SldWorks();

                swApp.ExitApp();
                swApp = null;
            }
            catch
            {
                MessageBox.Show("Error on Solidworks app startup");
            }
                }

        private void swCreateLine()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            swAppStart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            swCreateLine();
        }
    }
}
