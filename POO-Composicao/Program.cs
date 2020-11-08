using POO_Composicao.Entidades;
using POO_Composicao.Enums;
using System;
using System.Globalization;

namespace POO_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente(1, "Flávio", "flavio@gmail.com",new DateTime(1979, 02, 25));

            Produto produto1 = new Produto(1, "TV", 1000);
            Produto produto2 = new Produto(2, "Mouse", 40);
            Produto produto3 = new Produto(2, "Teclado", 50);

            ItemPedido item1 = new ItemPedido(1, 1000, 1, produto1);
            ItemPedido item2 = new ItemPedido(2, 40, 2, produto2);
            ItemPedido item3 = new ItemPedido(3, 50, 3, produto3);

            Pedido pedido = new Pedido(1, DateTime.Now, Status.PROCESSANDO, cliente);

            pedido.AdionarItem(item1);
            pedido.AdionarItem(item2);
            pedido.AdionarItem(item3);

            // pedido.RemoverItem(item2);

            MostrarPedido(pedido);          

            Console.ReadKey();
        }

        public static void MostrarPedido(Pedido pedido)
        {
            Console.WriteLine("Sumário Pedido");
            Console.WriteLine("Momento do Pedido: " + pedido.DataPedido);
            Console.WriteLine("Status do Pedido: " + pedido.Status);
            Console.WriteLine("Cliente: " + pedido.Cliente.Nome + " (" + pedido.Cliente.DataNascimento + ") - " + pedido.Cliente.Email);
            Console.WriteLine();
            Console.WriteLine("Itens");
            foreach (var item in pedido.ObterItens())
            {
                Console.WriteLine("\t" + item.Produto.Nome + ", R$" + item.Preco + ", " + item.Quantidade + ", Subtotal: " + item.SubTotal());
            }
            Console.WriteLine();
            Console.WriteLine("Total da compra: " + pedido.Total());
        }

        public static string ObterDataAtual()
        {
            DateTime dataAtual = DateTime.Now;
            String culture = "br-BR";
            var cultures = new CultureInfo(culture);
           
            return dataAtual.ToString(cultures);
        }
    }
}
