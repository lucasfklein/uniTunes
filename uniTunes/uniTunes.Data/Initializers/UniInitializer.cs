using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using uniTunes.Models;
using System.Data.SqlClient;

namespace uniTunes.Data.Initializers
{
    /// <summary>
    /// Classe responsável pela ação de inserir registros nas tabelas ao Dropar/Criar a database.
    /// </summary>
    public class UniInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniContext>
    {
        protected override void Seed(UniContext context)
        {
            SqlConnection.ClearAllPools();

            var students = new List<Academic>
            {
                new Academic{
                    Login="admin",
                    Password="123",
                    FirstName="Administrator",
                    Email="fcm1990@gmail.com",
                    Question = "Quanto é 2+2?",
                    Answer = "4",
                    Link = LinkType.Administrator
                }
            };

            students.ForEach(s => context.Academics.Add(s));
            context.SaveChanges();
        }
    }
}
