using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiClickDerecho20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                string nombreForm = Application.OpenForms[i].ToString();
                if (nombreForm.Contains("FrmPpal") != false)
                {
                    MessageBox.Show("Esta Abierto");
                    return;
                }
            }



            FrmPpal FrmPpal = new FrmPpal();

            FrmPpal.MdiParent = this;
            FrmPpal.StartPosition = FormStartPosition.CenterParent; 

            FrmPpal.Show();
            //FrmPpal.Dock = DockStyle.Fill;

            FrmPpal.WindowState = FormWindowState.Normal;
            FrmPpal.StartPosition = FormStartPosition.CenterParent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
