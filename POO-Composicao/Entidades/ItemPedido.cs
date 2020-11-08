using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Composicao.Entidades
{
    public class ItemPedido
    {
        public ItemPedido(int id, double preco, int quantidade, Produto produto)
        {
            this.id = id;
            this.preco = preco;
            this.quantidade = quantidade;
            Produto = produto;
        }

        private int id;
        public int Id
        {
            get { return id; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
        }

        public Produto Produto { get; set; }

        public double SubTotal()
        {
            return quantidade * preco;
        }

    }
}
