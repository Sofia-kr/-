using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОБЗД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Калькулятор calc = new Калькулятор();
            calc.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void таблиціБДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenTableDoslid_Click(object sender, EventArgs e)
        {
            Doslid doslid = new Doslid();
            doslid.ShowDialog();
        }

        private void OpenTableDoslidnyk_Click(object sender, EventArgs e)
        {
            Doslidnyk doslidnyk = new Doslidnyk();
            doslidnyk.ShowDialog();
        }

        private void OpenTableRoslyny_Click(object sender, EventArgs e)
        {
            Roslyny roslyny = new Roslyny();
            roslyny.ShowDialog();
        }
        
    } 

}
