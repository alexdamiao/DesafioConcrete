using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DesafioConcrete.Core
{
    public class UsuarioManager : UserManager<IdentityUser>
    {
        public UsuarioManager() : base(new UsuarioStore())
        {
        }
    }
}