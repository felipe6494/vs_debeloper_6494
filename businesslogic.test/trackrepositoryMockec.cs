using AutoFixture;
using DataAccess;
using DataAccess.repositories;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslogic.test
{
    public class trackrepositoryMockec
    {
        private readonly List<Track> _tracks;


        public trackrepositoryMockec()
        {
            _tracks = getTracks();
        }
        public IUnitOfWork getinstance()
        {
            var mocked = new Mock<IUnitOfWork>();
            mocked.Setup(c => c.Tracks).Returns(gettrackmocked);
            return mocked.Object;
        }
        private ITrackRepository gettrackmocked()
        {
            var trackmokecd = new Mock<ITrackRepository>();
            trackmokecd.Setup(c => c.GetAll()).Returns(_tracks);
            trackmokecd.Setup(d => d.GetByID(It.IsAny<int>())).
                Returns((int id) => _tracks.FirstOrDefault(x => x.TrackId == id));
            return trackmokecd.Object;
        }
        private List<Track> getTracks()
        {
            //    var fixture = new Fixture();
            //    var tracks = fixture.CreateMany<Track>(10).ToList();

            //    for (int i = 0; i < 10; i++)
            //    {
            //        tracks[i].TrackId = i + 1;
            //    }
            //    return tracks;
            //}
            return new List<Track>
            {new Track{ TrackId=1,Composer="cibertec"},
              new Track{ TrackId=2,Composer="cibertec2"}

            };
        }
    }
}
