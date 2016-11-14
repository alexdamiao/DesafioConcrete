using Microsoft.AspNet.Identity.EntityFramework;

namespace DesafioConcrete.Core
{
    public class UsuarioStore : UserStore<IdentityUser>
    {
        public UsuarioStore() : base(new DesafioConcreteContext())
        {

        }
    }
}