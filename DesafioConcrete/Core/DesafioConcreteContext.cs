using System.Data.Entity;
using DesafioConcrete.Models;
using System.Collections.Generic;

namespace DesafioConcrete.Core
{
    /// <summary>
    /// Classe de criação do ContextoS
    /// </summary>
    public class DesafioConcreteContext : DbContext
    {
        private static List<Usuario> Usuarios;

        public static List<Usuario> Context {
            get {
                if (Usuarios == null)
                {
                    Usuarios = new List<Usuario>();
                }

                return Usuarios;
            }
            set {

                Usuarios = value;
            }
        }


    }
}