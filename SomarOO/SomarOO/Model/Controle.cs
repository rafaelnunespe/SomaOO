using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarOO.Model
{
    public class Controle
    {
        public String numero1;
        public String numero2;
        public String resposta;
        public String mensagem;

        public Controle(string numero1, string numero2, string resposta)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.resposta = resposta;
        }

        public void Executar()
        {
            this.mensagem = "";

            Verifica verifica = new Verifica(numero1, numero2);
            verifica.Verificar();
            this.mensagem = verifica.mensagem;

            Calcula calcula = new Calcula(verifica.n1,verifica.n2);
            calcula.Calcular();
            this.resposta = calcula.resultado.ToString();
        }
    }
}
