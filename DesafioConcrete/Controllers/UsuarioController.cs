using DesafioConcrete.Core;
using System.Web.Http;
using DesafioConcrete.Models;
using System;

namespace DesafioConcrete.Controllers
{
    /// <summary>
    /// Controle de Usuários (endppotins)
    /// </summary>
    public class UsuarioController : ApiController
    {
        /// <summary>
        /// Executa o Login de um usuário
        /// </summary>
        /// <param name="email">email para autenticação</param>
        /// <param name="senha">senha em texto para cálculo do Hash</param>
        [HttpGet]
        public string Login(string email, string senha)
        {
            UsuarioRepositorio _usuario = new UsuarioRepositorio();
            senha = Hash.sha256encrypt(senha);

            return _usuario.FindByEmailSenha(email, senha).token;
        }

        /// <summary>
        /// Cadastro de Usuário
        /// </summary>
        /// <param name="nome">Nome do Usuário</param>
        /// <param name="senha">senha em texto para cálculo do Hash</param>
        /// <param name="email">Email do Usuário</param>
        /// <param name="telefone">Telefone do usuário com o DDD</param>
        [HttpPost]
        public void SignUp(string nome, string senha, string email, object[] telefone)
        {
            Usuario _usuario = ObjectFactory.CriarUsuario(Guid.NewGuid(), nome, email, senha);
            UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();
            
            foreach (object x in telefone)
            {
                UsuarioTelefone _tel = ((UsuarioTelefone)(x));

                _usuario.AdicionarTelefone(_tel.ddd, _tel.numero);
            }

            _usuarioRepositorio.Add(_usuario);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        public Usuario Profile(Guid id)
        {
            UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();

            var _usuario = _usuarioRepositorio.FindById(id);

            return _usuario;
        }
    }
}