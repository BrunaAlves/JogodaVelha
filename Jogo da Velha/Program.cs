using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha
{
    class Program
    {
        static void Main(string[] args)
        {
            Velha velha = new Velha();
            string partida = null;
            int vencedor = 0;

            partida = "x:2,2 o:2,1 x:3,3 o:1,1 x:3,1 o:1,3 x:3,2";
            vencedor = velha.QuemVenceu(partida);
            Console.WriteLine("x venceu.: " + (vencedor == -1));

            partida = "x:1,1 o:3,3 x:2,2 o:3,1 x:3,2 o:1,2 x:2,1 o:2,3 x:1,3";
            vencedor = velha.QuemVenceu(partida);
            Console.WriteLine("deu velha: " + (vencedor == 0));

            partida = "x:1,1 o:2,3 x:3,3 o:2,2 x:3,1 o:2,1";
            vencedor = velha.QuemVenceu(partida);
            Console.WriteLine("o venceu.: " + (vencedor == 1));

            Console.ReadKey();
        }
    }
}
