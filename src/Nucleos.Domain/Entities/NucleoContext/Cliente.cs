using Nucleos.Domain.Enums;
using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

    public class Cliente : BaseEntity
    {
        public Cliente(string nome, string email, string telefone, Document document, string observacao, bool ativo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Document = document;
            Observacao = observacao;
            Ativo = ativo;
          
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Document Document { get; private set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }

    } 
 