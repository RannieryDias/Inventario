using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_POLI
{
    class GerenciarEquipamentos
    {
        static void Main(string[] args)
        {
            Equipamento novoEquipamento = new Equipamento();
            
            Console.WriteLine("Vamos cadastrar um novo equipamento!");
            Console.Write("Começando pelo nome(tipo) do equipamento: ");
            novoEquipamento.Nome = Console.ReadLine();
            Console.Write("\nModelo: ");
            novoEquipamento.Modelo = Console.ReadLine();
            Console.Write("\nFabricante: ");
            novoEquipamento.Fabricante = Console.ReadLine();
            Console.Write("\nLocalOriginal: ");
            novoEquipamento.LocalOriginal = Console.ReadLine();
            /*Console.Write("");
            novoEquipamento = Console.ReadLine();
            Console.Write("");
            novoEquipamento = Console.ReadLine();*/


            Console.WriteLine(novoEquipamento);
        }
    }
}
