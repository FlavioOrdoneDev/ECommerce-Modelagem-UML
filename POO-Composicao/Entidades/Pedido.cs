using POO_Composicao.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Composicao.Entidades
{
    public class Pedido
    {
        private List<ItemPedido> Itens = new List<ItemPedido>();

        public Pedido(int id, DateTime dataPedido, Status status, Cliente cliente)
        {
            this.id = id;
            this.dataPedido = dataPedido;
            this.status = status;
            Cliente = cliente; 
        }

        private int id;
        public int Id
        {
            get { return id; }
        }

        private DateTime dataPedido;
        public DateTime DataPedido
        {
            get { return dataPedido; }
        }

        private Status status;
        public Status Status
        {
            get { return status; }
        }

        public Cliente Cliente { get; set; }

        public void AdionarItem(ItemPedido itemPedido)
        {
            Itens.Add(itemPedido);
        }

        public List<ItemPedido> ObterItens()
        {
            return Itens;
        }

        public void RemoverItem(ItemPedido itemPedido)
        {
            Itens.Remove(itemPedido);
        }

        public double Total()
        {
            return Itens.Sum(i => i.SubTotal());
        }

    }
}
