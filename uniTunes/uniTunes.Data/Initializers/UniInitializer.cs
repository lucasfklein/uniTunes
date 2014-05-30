using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using uniTunes.Models;

namespace uniTunes.Data.Initializers
{
    /// <summary>
    /// Classe responsável pela ação de inserir registros nas tabelas ao Dropar/Criar a database.
    /// </summary>
    public class UniInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniContext>
    {
        protected override void Seed(UniContext context)
        {
            var students = new List<Academic>
            {
                new Academic{
                    Login="admin",
                    Password="123",
                    FirstName="Administrator",
                    Email="teste",
                }
            };

            students.ForEach(s => context.Academics.Add(s));
            context.SaveChanges();
        }
    }
}
