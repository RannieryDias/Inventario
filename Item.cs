using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_POLI
{
    class Item
    {
        private string _nome;
        public string Nome
        {
            set
            {
                if (value == null)
                {

                }
                else
                {
                    _nome = value;
                }
            }
            get
            {
                return _nome;
            }
        }

        public string _marca;
        public string Marca
        {
            set
            {
                if (value == null)
                {

                }
                else
                {
                    _marca = value;
                }
            }
            get
            {
                return _marca;
            }
        }

        private int _protocolo;
        public int Protocolo
        {
            set
            {
                if (value == 0 || value < 0)
                {

                }
                else
                {
                    _protocolo = value;
                }
            }
            get
            {
                return _protocolo;
            }
        }

        public string LocalAtual
        {
            set;
            get;
        }

        public bool Emprestado
        {
            set;
            get;
        }

        public void Cadastrar()
        {

        }

    }
}
