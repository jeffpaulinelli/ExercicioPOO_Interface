using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciointerface
{
    public class LutadorJudo : Lutador
    {
        private string Nome;
        public int ataque() => 300 * aleatorio();

        public int defesa() => 300 * aleatorio();
        internal int aleatorio()
        {
            Random aleatorio = new Random();
            int valor = aleatorio.Next(1,10);
            return valor;
        }

        public string nome() => Nome;
        public LutadorJudo(string Nome)
        {
            this.Nome = Nome;
        }
    }
}
