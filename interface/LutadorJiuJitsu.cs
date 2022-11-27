using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciointerface
{
    public class LutadorJiuJitsu : Lutador
    {
        private string Nome;
        public int ataque() => 200 * aleatorio();

        public int defesa() => 200 * aleatorio();
        internal int aleatorio()
        {
            Random aleatorio = new Random();
            int valor = aleatorio.Next(1, 10);
            return valor;
        }

        public string nome() => Nome;
        public LutadorJiuJitsu(string Nome)
        {
            this.Nome = Nome;
        }
    }
}
