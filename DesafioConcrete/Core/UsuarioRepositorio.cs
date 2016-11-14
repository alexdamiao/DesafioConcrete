using DesafioConcrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioConcrete.Core
{
    public class UsuarioRepositorio : IRepository<Usuario>
    {

        List<Usuario> _context;

        public UsuarioRepositorio()
        {
            _context = DesafioConcreteContext.Context;
        }
        public IEnumerable<Usuario> List
        {
            get
            {
                return _context;
            }
        }

        public void Add(Usuario usuario)
        {
            _context.Add(usuario);
            //_context.SaveChanges();
        }

        public void Delete(Usuario usuario)
        {
            _context.Remove(usuario);
            //_context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Remove(usuario);
            _context.Add(usuario);
            //_context.SaveChanges();

        }

        public Usuario FindById(Guid id)
        {
            var result = (from r in _context where r.id == id select r).FirstOrDefault();
            return result;
        }

        public Usuario FindByNome(string nome)
        {
            var result = (from r in _context where r.nome == nome select r).FirstOrDefault();
            return result;
        }

        public Usuario FindByEmailSenha(string email, string senha)
        {
            var result = (from r in _context where r.email == email && r.senha == senha select r).FirstOrDefault();
            
            _context.Remove(result);
            result.token = Hash.sha256encrypt(Guid.NewGuid().ToString());

            _context.Add(result);
            return result;
        }
    }
}