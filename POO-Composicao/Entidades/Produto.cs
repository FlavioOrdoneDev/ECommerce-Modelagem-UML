using POO_Composicao.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace POO_Composicao.Entidades
{
    public class Produto
    {
        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;            
        }

        private int id;
        public int Id
        {
            get { return id; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
        }        
    }
}
