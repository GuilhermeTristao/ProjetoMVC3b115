﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetomvc3b115.DTO
{
    public class tblClienteDTO
    {
        private int tp_usuario;
        private string nome_cliente, sobrenome_cliente, cpf_cliente, senha_cliente, email_cliente;

        public int Id_cliente { get; set; }
        public int Tp_usuario { get => tp_usuario; set => tp_usuario = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value; }

        public string Email_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email_cliente = value;
                }
                else
                {
                    throw new Exception("O campo Email é obrigatório.");
                }
            }
            get { return this.email_cliente; }
        }

        public string Senha_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.senha_cliente = value;
                }
                else
                {
                    throw new Exception("O campo senha é obrigatório.");
                }
            }
            get { return this.senha_cliente; }
        }





    }
}
