using DataAccess.repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public  interface IUnitOfWork:IDisposable
    {
        IArtisitRepository Artisit { get;}
        ITrackRepository Tracks { get; }
        IRepository<Playlist> playlist { get; }
        IRepository<Genre> Genre { get; }
        IRepository<MediaType> MediaType { get; }
        IRepository<Album> Album { get; }
        int complete();
    }
}
