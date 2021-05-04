using System;
using System.Collections.Generic;
using System.Text;

namespace AppListaDeComprasEtec
{
    class Produto
    {
        string descricao;
        int quantidade;
        double preco_unitario;
        double preco_total;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double PrecoUnitario
        {
            get { return preco_unitario; }
            set { preco_unitario = value; }
        }

        public double PrecoTotal
        {
            get { return quantidade * preco_unitario; }
            
            //set { preco_total = value; }
        }
    }
}
