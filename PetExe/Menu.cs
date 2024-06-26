using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetExe
{
    public class Menu
    {
        public void startMenu() 
        {
            int menuIterator = 0;

            do
            {
                Console.WriteLine("Escolha uma opção para podermos começar: ");
                Console.WriteLine("1-Cadastro de Pet");
                Console.WriteLine("0-Sair");
                
                menuIterator = Convert.ToInt32(Console.ReadLine());

                switch (menuIterator) 
                {
                    case 0:
                        Console.WriteLine("Até mais");
                        break;
                    case 1:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Digite novamente");
                        break;
                }

            } while (menuIterator != 0);
        }
    }
}
