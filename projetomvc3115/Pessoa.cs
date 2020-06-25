using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetomvc3b115
{
    public class Pessoa
    {
        private string nome;
        private string cpf;
        private string nomeMae;

        public string Cpf
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf = value;
                }
                else
                {
                    throw new Exception("O CPF deve ser obrigatoriamente preenchido pelo usuário.");
                }
            }
            get { return this.cpf; }
        }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido pelo usuário.");
                }
            }
            get { return this.nome; }
        }

        public string NomeMae
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeMae = value;
                }
                else
                {
                    throw new Exception("O nome da mãe deve ser obrigatoriamente preenchido pelo usuário.");
                }
            }
            get { return this.nomeMae; }
        }

        public string ImprimeDados()
        {
            return "Dados da pessoa: \n\nNome: " +
                    this.Nome + "\nCPF: " +
                    this.Cpf + "\nNome da Mãe: " +
                    this.NomeMae;
        }
    }
}
