using DesafioConcrete.Core;
using System;

namespace DesafioConcrete
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            System.Data.Entity.Database.SetInitializer(new Initializer());            
        }
    }
}