using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarOO.Model
{
    public class Verifica : Propriedades
    {
        private String numero1;
        private String numero2;
        public int n1;
        public int n2;

        public Verifica(string num1, string num2) : base(num1, num2, "")
        {
            this.numero1 = num1;
            this.numero2 = num2;
        }

        public void Verificar()
        {
            mensagem = "";
            try
            {
                n1 = Convert.ToInt32(numero1);
                n2 = Convert.ToInt32(numero2);
            }
            catch (Exception)
            {
                mensagem = "Favor informar um valor numérico!";
            }
        }

    }
}
