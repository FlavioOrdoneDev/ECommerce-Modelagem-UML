using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Composicao.Entidades
{
    public class Cliente
    {
        public Cliente(int id, string nome, string email, DateTime dataNascimento)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.dataNascimento = dataNascimento;
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

        private string email;
        public string Email
        {
            get { return email; }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
        }
    }
}
