using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TayMark_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void OpenContainerPanel(Form containerForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = containerForm;
            containerForm.TopLevel = false;
            containerForm.FormBorderStyle = FormBorderStyle.None;
            containerForm.Dock = DockStyle.Fill;
            panelContainerPanel.Controls.Add(containerForm);
            panelContainerPanel.Tag = containerForm;
            containerForm.BringToFront();
            containerForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
