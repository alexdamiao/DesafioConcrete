using DesafioConcrete.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;

namespace DesafioConcrete.Core
{
    public class AuthRepository : IDisposable
    {
        private DesafioConcreteContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new DesafioConcreteContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(Usuario userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.nome
            };

            var result = await _userManager.CreateAsync(user, userModel.senha);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}