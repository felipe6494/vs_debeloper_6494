using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLogic
{
     public class tracklogoc
    {
        public readonly IUnitOfWork _iunitofWork;
        public tracklogoc(IUnitOfWork unitOfWork)
        {
            _iunitofWork = unitOfWork;
        }
        public string Getcomposer(int id)
        {
            var list = _iunitofWork.Tracks.GetAll().ToList();
            var record = list.FirstOrDefault(x => x.TrackId == id);
           
            return record.Composer;
        }
        public int GEtcoposerByid(int id)
        {
            var record = _iunitofWork.Tracks.GetByID(id);
            return record.TrackId;
        }
    }
}
