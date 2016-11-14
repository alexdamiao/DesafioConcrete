using DesafioConcrete.Models;
using System;

namespace DesafioConcrete.ViewModel
{
    public class UsuarioTelefoneViewModel
    {
        public UsuarioTelefoneViewModel()
        {
        }

        public UsuarioTelefoneViewModel(UsuarioTelefone usuarioTelefone)
        {
            if (usuarioTelefone == null)
            {
                new ApplicationException("É necessário informar o telefone do usuário!");
            }

            
            numero = usuarioTelefone.numero;
            ddd = usuarioTelefone.ddd;
        }

        public Guid usuarioId { get; set; }

        public string numero { get; set; }

        public string ddd { get; set; }

        public UsuarioTelefone ToUsuarioTelefone()
        {
            return new UsuarioTelefone
            {
                numero = numero,
                ddd = ddd
            };
        }
    }
}