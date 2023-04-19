using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarOO.Model
{
    public class Calcula : Propriedades
    {
        public int n1;
        public int n2;
        public int resultado;

        public Calcula(int n1, int n2) : base(n1, n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void Calcular()
        {
            resultado = n1 + n2;
        }


    }
}
