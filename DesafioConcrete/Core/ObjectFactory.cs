using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DesafioConcrete.Models;

namespace DesafioConcrete.Core
{
    /// <summary>
    /// Representa uma fábrica de Objetos
    /// </summary>
    public class ObjectFactory
    {
        /// <summary>
        /// Retorna um usuário frente aos dados enviados
        /// </summary>
        /// <returns></returns>
        public static Usuario CriarUsuario(Guid usuarioId, string nome, string email, string senha)
        {
            var usuarioTemporario = new Usuario();

            usuarioTemporario.id = usuarioId;
            usuarioTemporario.nome = nome;
            usuarioTemporario.email = email;
            usuarioTemporario.data_criacao = DateTime.Now;
            usuarioTemporario.data_atualizacao = DateTime.Now;
            usuarioTemporario.ultimo_login = DateTime.Now;

            usuarioTemporario.senha = Hash.sha256encrypt(senha);


            return usuarioTemporario;
        }

    }
}