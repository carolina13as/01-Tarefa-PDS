using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa01_PDS
{
    public partial class Empresas : Form
    {
        List<Empresa> Ltempresas = new List<Empresa>();
        public Empresas()
        {
            InitializeComponent();          
        }
        public Empresas(List<Empresa>a)
        {
            InitializeComponent();
            Ltempresas = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado pela preferencia!!");
            Empresa a = new Empresa(maskedTextBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text, maskedTextBox1.Text, textBox7.Text, textBox4.Text,
                textBox3.Text, textBox5.Text, textBox6.Text, comboBox2.Text, Tipo(), Porte_Empresarial(), comboBox3.Text, textBox8.Text, maskedTextBox2.Text,
                Regime_Tributario(),dateTimePicker1.Text);
            Ltempresas.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1(Ltempresas);
            a.ShowDialog();
        }

        public String Tipo()
        {
            if (radioButton3.Checked == true)
            {
                return radioButton3.Text;   
            }
            else if (radioButton4.Checked == true)
            {
                return radioButton4.Text;
            }
            else
            {
                return " ";
            }
        }

        public String Porte_Empresarial()
        {
            if (radioButton8.Checked == true)
            {
                return radioButton8.Text;
            }
            else if (radioButton5.Checked == true)
            {
                return radioButton5.Text;
            }
            else if (radioButton7.Checked == true)
            {
                return radioButton7.Text;
            }
            else
            {
                return " ";
            }
        }

        public String Regime_Tributario()
        {
            if (radioButton2.Checked == true)
            {
                return radioButton2.Text;
            }
            else if (radioButton1.Checked == true)
            {
                return radioButton1.Text;
            }            
            else
            {
                return " ";
            }
        }
    }
}
