using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repositories
{
    public interface IArtisitRepository:IRepository<Artist>
    {
        Artist GetByName(string name);
          IEnumerable<Artist> GetListOfArtistSp();
        void InsertarRegistrosPrueba();
    }
}
