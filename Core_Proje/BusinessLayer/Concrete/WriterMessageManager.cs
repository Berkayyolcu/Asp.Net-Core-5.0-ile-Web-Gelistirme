using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _WriterMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _WriterMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetList()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _WriterMessageDal.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _WriterMessageDal.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _WriterMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _WriterMessageDal.Delete(t);
        }

        public WriterMessage TGetByID(int id)
        {
            return _WriterMessageDal.GetByID(id);
        }

        //public List<WriterMessage> TGetListbyFilter(string p)
        //{
        //    return _WriterMessageDal.GetbyFilter(x => x.Receiver == p);
        //}

        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
