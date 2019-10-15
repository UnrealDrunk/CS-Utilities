using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;


        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мои Утилиты. Содержат набор простеньких приятных учебных программ. Автор: U_Drunk",
                "О программе");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            lblRandom.Text = n.ToString();

            if(cbRandom.Checked)
            {
                int i =0;
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    i++;
                    if (i > numericUpDown2.Value - numericUpDown1.Value) break;
                }
      
                if(i <= numericUpDown2.Value - numericUpDown1.Value)
                    tbRandom.AppendText(n + "\t");
            }
            else
                tbRandom.AppendText(n + "\t");



        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }
    }
}
