using DesafioConcrete.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioConcrete.Models
{
    [Table("UsuarioTelefone")]
    /// <summary>
    /// Representa o Telefone com DDD de um determinado usuário
    /// </summary>
    public class UsuarioTelefone : IEntity
    {
        /// <summary>
        /// ID do telefone
        /// </summary>
        public new Guid id { get; set; }

        /// <summary>
        /// Número do telefone
        /// </summary>
        public string numero { get; set; }

        /// <summary>
        /// Código DDD do telefone
        /// </summary>
        public string ddd { get; set; }
    }
}