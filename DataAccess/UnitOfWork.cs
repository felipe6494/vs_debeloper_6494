using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.repositories;
using Models;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        public IArtisitRepository Artisit { get; private set; }

        public ITrackRepository Tracks { get; private set; }
             
        public IRepository<Playlist> playlist { get; private set; }

        public IRepository<Genre> Genre { get; private set; }

        public IRepository<MediaType> MediaType { get; private set; }

        public IRepository<Album> Album { get; private set; }

        public readonly DatabaseContext _context;
        public UnitOfWork(DatabaseContext context) {

            _context = context;
            //no olvidar inicializar 
            Artisit = new ArtitsRepository(_context);
            Tracks = new TrackRepository(_context);
            playlist = new Repository<Playlist>(_context);
            Genre = new Repository<Genre>(_context);
            MediaType = new Repository<MediaType>(_context);
            Album = new Repository<Album>(_context);

        }
        public int complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
