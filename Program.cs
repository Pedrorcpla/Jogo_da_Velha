using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6_10._09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] area = new string[3, 3];
            int contador = 0, x, y, p = 1;
  
            area[0, 0] = "-"; area[0, 1] = "-"; area[0, 2] = "-"; area[1, 0] = "-"; area[1, 1] = "-"; area[1, 2] = "-"; area[2, 0] = "-"; area[2, 1] = "-"; area[2, 2] = "-";
            do
            {
                Console.Clear();
                Console.WriteLine("     JOGO DA VELHA!      ");
                Console.WriteLine("       " + area[0, 0] + " | " + area[0, 1] + " | " + area[0, 2] + "  ");
                Console.WriteLine("      ___|___|___");
                Console.WriteLine("       " + area[1, 0] + " | " + area[1, 1] + " | " + area[1, 2] + "  ");
                Console.WriteLine("      ___|___|___");
                Console.WriteLine("       " + area[2, 0] + " | " + area[2, 1] + " | " + area[2, 2] + "  ");
                Console.WriteLine("         |   |   \n");
                Console.WriteLine("\nInforme as coordenadas: (3x3)\n\n");
                Console.Write("x: ");
                x = int.Parse(Console.ReadLine())-1;
                Console.Write("y: ");
                y = int.Parse(Console.ReadLine())-1;

                if (contador % 2 == 0)
                {
                    area[x, y] = "X";
                }
                else
                {
                    area[x, y] = "O";
                }

                if ((area[0, 0] == "X") && (area[0, 1] == "X") && (area[0, 2] == "X"))
                {
                    p = 0;
                }
                if ((area[1, 0] == "X") && (area[1, 1] == "X") && (area[1, 2] == "X"))
                {
                    p = 0;
                }
                if ((area[2, 0] == "X") && (area[2, 1] == "X") && (area[2, 2] == "X"))
                {
                    p = 0;
                }
                if ((area[0, 0] == "X") && (area[1, 0] == "X") && (area[2, 0] == "X"))
                {
                    p = 0;
                }
                if ((area[0, 1] == "X") && (area[1, 1] == "X") && (area[2, 1] == "X"))
                {
                    p = 0;
                }
                if ((area[0, 2] == "X") && (area[1, 2] == "X") && (area[2, 2] == "X"))
                {
                    p = 0;
                }
                if ((area[0, 0] == "X") && (area[1, 1] == "X") && (area[2, 2] == "X"))
                {
                    p = 0;
                }
                if ((area[0, 2] == "X") && (area[1, 1] == "X") && (area[2, 0] == "X"))
                {
                    p = 0;
                }

                if ((area[0, 0] == "O") && (area[0, 1] == "O") && (area[0, 2] == "O"))
                {
                    p = 0;
                }
                if ((area[1, 0] == "O") && (area[1, 1] == "O") && (area[1, 2] == "O"))
                {
                    p = 0;
                }
                if ((area[2, 0] == "O") && (area[2, 1] == "O") && (area[2, 2] == "O"))
                {
                    p = 0;
                }
                if ((area[0, 0] == "O") && (area[1, 0] == "O") && (area[2, 0] == "O"))
                {
                    p = 0;
                }
                if ((area[0, 1] == "O") && (area[1, 1] == "O") && (area[2, 1] == "O"))
                {
                    p = 0;
                }
                if ((area[0, 2] == "O") && (area[1, 2] == "O") && (area[2, 2] == "O"))
                {
                    p = 0;
                }
                if ((area[0, 0] == "O") && (area[1, 1] == "O") && (area[2, 2] == "O"))
                {
                    p = 0;
                }
                if ((area[0, 2] == "O") && (area[1, 1] == "O") && (area[2, 0] == "O"))
                {
                    p = 0;
                }

                contador++;
            } while (p != 0);

            Console.Clear();
            Console.WriteLine("     JOGO DA VELHA!      ");
            Console.WriteLine("       " + area[0, 0] + " | " + area[0, 1] + " | " + area[0, 2] + "  ");
            Console.WriteLine("      ___|___|___");
            Console.WriteLine("       " + area[1, 0] + " | " + area[1, 1] + " | " + area[1, 2] + "  ");
            Console.WriteLine("      ___|___|___");
            Console.WriteLine("       " + area[2, 0] + " | " + area[2, 1] + " | " + area[2, 2] + "  ");
            Console.WriteLine("         |   |   \n");

            if ((area[0, 0] == "X") && (area[0, 1] == "X") && (area[0, 2] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }
            if ((area[1, 0] == "X") && (area[1, 1] == "X") && (area[1, 2] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }
            if ((area[2, 0] == "X") && (area[2, 1] == "X") && (area[2, 2] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }
            if ((area[0, 0] == "X") && (area[1, 0] == "X") && (area[2, 0] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }
            if ((area[0, 1] == "X") && (area[1, 1] == "X") && (area[2, 1] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }
            if ((area[0, 2] == "X") && (area[1, 2] == "X") && (area[2, 2] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }
            if ((area[0, 0] == "X") && (area[1, 1] == "X") && (area[2, 2] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }
            if ((area[0, 2] == "X") && (area[1, 1] == "X") && (area[2, 0] == "X"))
            {
                Console.WriteLine("O Jogador 1 VENCEU!!!");
            }

            if ((area[0, 0] == "O") && (area[0, 1] == "O") && (area[0, 2] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            if ((area[1, 0] == "O") && (area[1, 1] == "O") && (area[1, 2] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            if ((area[2, 0] == "O") && (area[2, 1] == "O") && (area[2, 2] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            if ((area[0, 0] == "O") && (area[1, 0] == "O") && (area[2, 0] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            if ((area[0, 1] == "O") && (area[1, 1] == "O") && (area[2, 1] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            if ((area[0, 2] == "O") && (area[1, 2] == "O") && (area[2, 2] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            if ((area[0, 0] == "O") && (area[1, 1] == "O") && (area[2, 2] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            if ((area[0, 2] == "O") && (area[1, 1] == "O") && (area[2, 0] == "O"))
            {
                Console.WriteLine("O Jogador 2 VENCEU!!!");
            }
            Console.ReadKey();
        }
    }
}
