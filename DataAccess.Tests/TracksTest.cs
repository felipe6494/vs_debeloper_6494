using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using FluentAssertions;
using Models;
using Xunit;

namespace ClassLibrary1
{
   public  class TracksTest
    {
        private readonly
            IUnitOfWork _unitOfWork;

        public TracksTest()
        {
            //donde se crea la connecion
            _unitOfWork = new UnitOfWork(new DatabaseContext());

        }
        [Fact]
        public void GEtByPlaylistID()
        {
            var tracks = _unitOfWork.Tracks.GETbyplaylist(1);
            tracks.Count().Should().Be(3290);
        }
    }
}
