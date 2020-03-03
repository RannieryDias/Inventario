using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_POLI
{
    class Principal
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Nome = "Modem";
            Console.WriteLine(item.Nome);
            Console.ReadLine();
        }
    }
}
