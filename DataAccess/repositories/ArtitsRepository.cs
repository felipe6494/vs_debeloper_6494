using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess.repositories
{
    public class ArtitsRepository :  Repository<Artist>, IArtisitRepository
    {
        public ArtitsRepository(DatabaseContext context) : base(context)
        {
        }

        public Artist GetByName(string name)
        {
            return Context.Artist.FirstOrDefault(a => a.Name == name);
        }

        public IEnumerable<Artist> GetListOfArtistSp()
        {
            return Context.Database.SqlQuery<Artist>("spGetListofArtist");
        }

        public void InsertarRegistrosPrueba()
        {
            var lista = new List<Artist>
            {
                new Artist { Name = "Mana"},
                new Artist { Name = "Metallica"},
                new Artist { Name = "Bareto"}
            };

            // insertar cada artista a la BD (a través del context)
            lista.ForEach(artist => Context.Artist.Add(artist));
            // commit
            //Context.SaveChanges();
        }
    }
}
