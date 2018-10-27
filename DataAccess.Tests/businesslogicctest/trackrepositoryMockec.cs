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

namespace ClassLibrary1.businesslogicctest
{
    public class trackrepositoryMockec

    {
       private readonly List<Track> _tracks;
 

        public trackrepositoryMockec()
        {
            _tracks = getTracks();
        }
        public IUnitOfWork getinstance()
        {    var mocked = new Mock<IUnitOfWork>();
            mocked.Setup(c => c.Tracks).Returns(gettrackmocked);
            return mocked.Object;
        }
        private ITrackRepository gettrackmocked ()
        {
            var trackmokecd = new Mock<ITrackRepository>();
            trackmokecd.Setup(c => c.GetAll()).Returns(_tracks);
            return trackmokecd.Object;
        }
        private List<Track> getTracks()
        {
            var fixture = new Fixture();
            var tracks = fixture.CreateMany<Track>(10).ToList();

            for (int i = 0; i < 10; i++)
            {
                tracks[i].TrackId = i + 1;
            }
            return tracks;
        }

    }
}
