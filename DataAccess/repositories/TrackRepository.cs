using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess.repositories
{
    public class TrackRepository : Repository<Track>,ITrackRepository
    {
        public TrackRepository(DatabaseContext context) : base(context)
        {
        }

        public IEnumerable<Track> GETbyplaylist(int Playlistid)
        {
            var tracks = Context.Playlist.Include(p => p.Tracks).
                FirstOrDefault(p => p.PlaylistId == Playlistid).Tracks;
            return tracks.ToList();
        }
       
    }
}
