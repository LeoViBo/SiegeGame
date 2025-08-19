using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Siege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siege is a tool for testing the resilience of systems under load.");
        }

        private void GameStart()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Siege! Press any key to start the game or 'q' to quit.");
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Q)
                {
                    break;
                }
                else
                {
                    // Start the game logic here
                    Console.WriteLine("Game started! Good luck!");
                    // Add game logic here
                }
            }
        }

        // ----- Chamados -----

        // Gera um número aleatório
        public int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Traduz o tipo o atributo primário de acordo com o nível do atributo
        public string Nota_AtriutoPrimario(int atributo)
        {
            if (atributo < 0 || atributo > 120)
            {
                return "Invalid Attribute";
            } else if (atributo < 20)
            {
                return "F";
            } else if (atributo < 40) 
            {
                return "D";
            } else if (atributo < 60)
            {
                return "C";
            } else if (atributo < 80)
            {
                return "B";
            } else if (atributo < 100)
            {
                return "A";
            } else
            {
                return "S";
            }
        }

        // Traduz o tipo o atributo secundário de acordo com o nível do atributo
        public string Nota_AtriutoSecundario(int atributo)
        {
            if (atributo < 0 || atributo > 6)
            {
                return "Invalid Attribute";
            }
            else if (atributo < 1)
            {
                return "F";
            }
            else if (atributo < 2)
            {
                return "D";
            }
            else if (atributo < 3)
            {
                return "C";
            }
            else if (atributo < 4)
            {
                return "B";
            }
            else if (atributo < 5)
            {
                return "A";
            }
            else
            {
                return "S";
            }
        }

        // Traduz o tipo o castelo de acordo com o nível do castelo
        public string Tipo_Castelo(int nivel)
        {
            if (nivel < 0 || nivel > 3)
            {
                return "Invalid Attribute";
            }
            else if (nivel < 1)
            {
                return "Madeira";
            }
            else if (nivel < 2)
            {
                return "Pedra";
            }
            else
            {
                return "Ferro";
            }
        }
    }
}
