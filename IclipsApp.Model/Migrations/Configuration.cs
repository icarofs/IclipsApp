namespace IclipsApp.Model.Migrations
{
    using IclipsApp.Model.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IclipsApp.Model.Context.IclipsAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IclipsApp.Model.Context.IclipsAppContext context)
        {
            var hasPessoas = context.Pessoa.Any();

            if (!hasPessoas)
            {
                var pessoas = new List<Pessoa>()
                {
                    new Pessoa { Nome = "David Koch", Email = "david@gmail.com", Situacao = 0 },
                    new Pessoa { Nome = "Charles Koch", Email = "koch@gmail.com", Situacao = 1 },
                    new Pessoa { Nome = "Michael Bloomberg", Email = "bloomberg@gmail.com", Situacao = 1 },
                    new Pessoa { Nome = "Larry Ellison", Email = "larry@gmail.com", Situacao = 1 },
                    new Pessoa { Nome = "Mark Zuckerberg", Email = "mark@gmail.com", Situacao = 1 },
                    new Pessoa { Nome = "Jeff Bezos", Email = "jeff@gmail.com", Situacao = 0 },
                    new Pessoa { Nome = "Carlos Slim", Email = "carlos@gmail.com", Situacao = 0 },
                    new Pessoa { Nome = "Warren Buffett", Email = "warren@gmail.com", Situacao = 1 },
                    new Pessoa { Nome = "Amâncio Ortega", Email = "ortega@gmail.com", Situacao = 0 },
                    new Pessoa { Nome = "Bill Gates", Email = "gates@gmail.com", Situacao = 0 }
                };

                context.Pessoa.AddRange(pessoas);
                context.SaveChanges();
            }
        }
    }
}
