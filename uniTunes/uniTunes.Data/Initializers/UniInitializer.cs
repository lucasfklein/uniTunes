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

            var academics = new List<Academic>
            {
                new Academic{Login="admin",Password="123",FirstName="Administrator",Email="fcm1990@gmail.com",Question = "Quanto é 2+2?",Answer = "4",Balance = 0,Link = LinkType.Administrator},
                new Academic{Login="felipe",Password="123",FirstName="Felipe",Email="fcm1990@gmail.com",Question = "Quanto é 2+2?",Answer = "4",Balance = 0,Link = LinkType.Employee},
                new Academic{Login="gustavo",Password="123",FirstName="Gustavo",Email="fcm1990@gmail.com",Question = "Quanto é 2+2?",Answer = "4",Balance = 0,Link = LinkType.Professor},
                new Academic{Login="helton",Password="123",FirstName="Helton",Email="fcm1990@gmail.com",Question = "Quanto é 2+2?",Answer = "4",Balance = 0,Link = LinkType.Student},
                new Academic{Login="guilherme",Password="123",FirstName="Guilherme",Email="fcm1990@gmail.com",Question = "Quanto é 2+2?",Answer = "4",Balance = 0,Link = LinkType.Employee}
            };

            var medias = new List<Media>
            {
                new Media{Author = academics.Single(x=>x.Login=="felipe"),CreatedOn=DateTime.Now,Description="Senhor dos Anéis",File= null,Length=150,MediaType=MediaType.Book,Name="Senhor dos Anéis",Price=5 },
                new Media{Author = academics.Single(x=>x.Login=="gustavo"),CreatedOn=DateTime.Now,Description="Violão Acústico I",File= null,Length=200,MediaType=MediaType.Music,Name="Violão Acústico I",Price=1.5 },
                new Media{Author = academics.Single(x=>x.Login=="felipe"),CreatedOn=DateTime.Now,Description="Artigo sobre TI",File= null,Length=20,MediaType=MediaType.Book,Name="Artigo sobre TI",Price=19.9 },
                new Media{Author = academics.Single(x=>x.Login=="felipe"),CreatedOn=DateTime.Now,Description="Podcast sobre TI",File= null,Length=300,MediaType=MediaType.Podcast,Name="Podcast sobre TI",Price=0 },
                new Media{Author = academics.Single(x=>x.Login=="helton"),CreatedOn=DateTime.Now,Description="Artigo sobre Testes",File= null,Length=10,MediaType=MediaType.Book,Name="Artigo sobre Testes",Price=0 },
                new Media{Author = academics.Single(x=>x.Login=="gustavo"),CreatedOn=DateTime.Now,Description="Violão Acústico II",File= null,Length=150,MediaType=MediaType.Music,Name="Violão Acústico II",Price=3 },
                new Media{Author = academics.Single(x=>x.Login=="felipe"),CreatedOn=DateTime.Now,Description="Video I",File= null,Length=180,MediaType=MediaType.Video,Name="Video I",Price=0 },
                new Media{Author = academics.Single(x=>x.Login=="guilherme"),CreatedOn=DateTime.Now,Description="Video II",File= null,Length=130,MediaType=MediaType.Video,Name="Video II",Price=0 },
                new Media{Author = academics.Single(x=>x.Login=="guilherme"),CreatedOn=DateTime.Now,Description="Video III",File= null,Length=110,MediaType=MediaType.Video,Name="Video III",Price=0 }
            };

            academics.ForEach(s => context.Academics.Add(s));
            medias.ForEach(m => context.Medias.Add(m));
            context.SaveChanges();
        }
    }
}
