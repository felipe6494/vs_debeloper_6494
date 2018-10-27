using businessLogic;
using DataAccess;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1.businesslogicctest
{
    public class tracklogictest
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly tracklogoc _tracklogoc;

        public tracklogictest()
        {
            var repomocked = new trackrepositoryMockec();
            _unitOfWork = repomocked.getinstance();
            _tracklogoc = new tracklogoc(_unitOfWork);
        }
        [Fact]
        public void GEtcomposer_track_test()
        {
            var result = _unitOfWork.Tracks.GetAll();
            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
        }
    }
}
