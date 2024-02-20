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
    public partial class Form1 : Form
    {
        List<Empresa> Ltempresas = new List<Empresa>();

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Empresa> a)
        {
            InitializeComponent();
            Ltempresas = a;
            if(Ltempresas.Count == 0)
            {
                button2.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresas a = new Empresas(Ltempresas);
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listagem_Empresas b = new Listagem_Empresas(Ltempresas);           
            b.ShowDialog();
        }
    }
}
