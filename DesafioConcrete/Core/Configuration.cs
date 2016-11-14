using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;
using DesafioConcrete.Models;
using System;
using System.Collections.Generic;

namespace DesafioConcrete.Core
{
    public class Configuration : DbMigrationsConfiguration<DesafioConcreteContext>
    {
        /// <summary>
        /// Configura o Migrations para atualização de Scheema e dados
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;

            Seed(new DesafioConcreteContext());
        }

        /// <summary>
        /// Popula o DataBase com dados de Teste
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DesafioConcreteContext context)
        {

            var random = new Bogus.Randomizer();
            var _context = DesafioConcreteContext.Context;

            for (int i = 0; i < 9; i++)
            {
                var person = new Bogus.Person(locale: "pt_BR");
                var usuarioNovo = ObjectFactory.CriarUsuario(Guid.NewGuid(), person.FirstName, person.Email, "123456");

                usuarioNovo.AdicionarTelefone("21", person.Phone);

                _context.Add(usuarioNovo);
            }
            

            //context.SaveChanges();
        }
    }
}