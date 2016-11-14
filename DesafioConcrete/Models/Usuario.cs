using DesafioConcrete.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioConcrete.Models
{
    [Table("Usuario")]
    /// <summary>
    /// Representa um usuário
    /// </summary>
    public partial class Usuario : IEntity
    {
        /// <summary>
        /// Id do Usuário
        /// </summary>
        public new Guid id { get; set; }

        /// <summary>
        /// Nome completo do Usuário
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// Emai do Usuário
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Senha do usuário. Hash simples
        /// </summary>
        public string senha { get; set; }

        /// <summary>
        /// Data de criação do Usuário
        /// </summary>
        public DateTime data_criacao { get; set; }

        /// <summary>
        /// Data da última atualização ocorrida nos dados do Usuário
        /// </summary>
        public DateTime data_atualizacao { get; set; }

        /// <summary>
        /// Data do último login realizado por esse usuário
        /// </summary>
        public DateTime ultimo_login { get; set; }

        /// <summary>
        /// Token atual do usuário [JWT como token generator, Hash simples]
        /// </summary>
        public string token { get; set; }


        public List<UsuarioTelefone> Telefones { get;}

        public Usuario()
        {
            this.Telefones = new List<UsuarioTelefone>();
        }


        /// <summary>
        /// Adiciona um telefone ao Usuário
        /// </summary>
        public void AdicionarTelefone(string ddd, string numero)
        {
            this.Telefones.Add(new UsuarioTelefone { ddd = ddd, numero= numero, id = System.Guid.NewGuid() });
        }
    }
}