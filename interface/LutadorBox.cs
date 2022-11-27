using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciointerface
{
    class LutadorBox : Lutador
    {
        private string Nome;
        public int ataque() => 100 * aleatorio();

        public int defesa() => 100 * aleatorio();
        internal int aleatorio() {
            Random aleatorio = new Random();
            int valor = aleatorio.Next(1,10);
            return valor;
        }

        public string nome() => Nome;
        public LutadorBox(string Nome)
        {
            this.Nome = Nome;
        }
    }
}
