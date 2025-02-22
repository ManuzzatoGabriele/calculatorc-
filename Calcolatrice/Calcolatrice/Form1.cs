using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_3.Text;

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_5.Text;

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_4.Text;

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_6.Text;

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_7.Text;

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_8.Text;

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_9.Text;

        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_punto.Text;

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_0.Text;

        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {

        }

        private void btn_diviso_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_diviso.Text;

        }

        private void btn_per_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_per.Text;

        }

        private void btn_meno_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_meno.Text;
        }

        private void btn_più_Click(object sender, EventArgs e)
        {
            lbl_schermo.Text += btn_più.Text;
        }

        private void lbl_schermo_Click(object sender, EventArgs e)
        {

        }
    }
}
