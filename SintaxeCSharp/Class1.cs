using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxeCSharp
{
    class ClasseAuxiliar
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public ClasseAuxiliar(int Codigo, int Idade, string Nome)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Idade = Idade;
        }

    }
}
