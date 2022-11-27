using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciointerface
{
    public class UFJudo
    {
        LutadorJudo l1, l2;
        int g1 = 0, g2 = 0;
        public UFJudo(string nome1, string nome2) //troquei o atributo do construtor como str para coletar o nome dos lutadores e eles estão implementados neste metodo
        {
            LutadorJudo l1 = new LutadorJudo(nome1);
            LutadorJudo l2 = new LutadorJudo(nome2);
            this.l1 = l1;
            this.l2 = l2;
        }
        bool golpel1() => (l1.ataque() - l2.ataque() > 0);
        bool golpel2() => (l2.ataque() - l1.ataque() > 0);
        int quemLuta()
        {
            if ((aleatorio() * 100) >= 200)
                return 1;
            return 0;
        }
        internal int aleatorio()
        {
            Random aleatorio = new Random();
            int valor = aleatorio.Next(0, 100);
            if (valor > 50)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public void luta()
        {
            for (int i = 0; i < 20; i++)
            {
                if (quemLuta() == 1)
                {
                    if (golpel1())
                    {
                        g1++;
                    }
                }else
                {
                    if (golpel2())
                    {
                        g2++;
                    }
                }
            }
        }
        void ganhou()
        {
            string str;
            if (g1 == g2)
                str = "Os lutadores " +
                    l1.nome() +
                    " e " +
                    l2.nome() +
                    " empataram o combate!";
            else
                str = "O lutador " +
                    $"{(g1 > g2 ? l1.nome() : l2.nome())}" +
                    " ganhou a luta!!";
            Console.WriteLine(str);
        }
        public void teste()
        {
            luta();
            ganhou();
        }
    }
}
