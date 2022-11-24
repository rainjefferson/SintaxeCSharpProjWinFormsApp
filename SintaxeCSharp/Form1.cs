using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintaxeCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClasseAuxiliar meuobj = new ClasseAuxiliar(1, 41, "Jefferson");

            this.richTextBox1.Text = "Objeto meuobj da classe ClasseAuxiliar";

            this.richTextBox1.AppendText("\r\nMeu teste");

            this.richTextBox1.AppendText("\r\n Codigo: " + meuobj.Codigo.ToString());
            this.richTextBox1.AppendText("\r\n Nome: " + meuobj.Nome);
            this.richTextBox1.AppendText("\r\n Idade: " + meuobj.Idade.ToString());

            this.listBox1.Items.Add(meuobj.Codigo.ToString());
            this.listBox1.Items.Add(meuobj.Nome);
            this.listBox1.Items.Add(meuobj.Idade.ToString());

            // Este é um comentário de uma linha

            /*
             Este é um bloco
             de comentário
             com varias linhas
             */

            // Blocos regions é recurso da IDE e não da linguagem C#
            #region ListBox1
            this.listBox1.Items.Add(meuobj.Codigo.ToString());
            this.listBox1.Items.Add(meuobj.Nome);
            this.listBox1.Items.Add(meuobj.Idade.ToString());
            #endregion

            #region Variaveis e tipos de dados
            // proximo projeto com console
            #endregion
        }
    }
}
