using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarOO.Model
{
    public class Propriedades
    {
        private String num1;
        private String num2;
        private String resposta;
        private int n1;
        private int n2;
        public String mensagem;

        public Propriedades(string num1, string num2, string resposta)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.resposta = resposta;
        }

        public Propriedades(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
    }
}
