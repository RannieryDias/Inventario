using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_POLI
{
    class Emprestimo
    {
        public Item item;
        public string LocalOrigem
        {
            set;
            get;
        }

        public string LocalDestino
        {
            set;
            get;
        }

        public void Emprestar(Item item, string LocalOrigem, string LocalDestino)
        {
            item = new Item();
            this.item = item;
            this.LocalOrigem = LocalOrigem;
            this.LocalDestino = LocalDestino;
            this.item.Emprestado = true;
        }
    }
}
