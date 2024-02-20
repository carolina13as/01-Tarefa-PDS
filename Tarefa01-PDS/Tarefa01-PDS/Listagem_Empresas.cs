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
    public partial class Listagem_Empresas : Form
    {
        List<Empresa> Ltempresas = new List<Empresa>();
        public Listagem_Empresas()
        {
            InitializeComponent();
        }
        public Listagem_Empresas(List<Empresa> a)
        {
            InitializeComponent();
            Ltempresas = a;
           
            
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = a;                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.ShowDialog();
        }
    }
}
