using ProjeForumSozluk.BusinessLayer.Abstract;
using ProjeForumSozluk.DataAccessLayer.Abstract;
using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _witerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _witerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _witerDal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _witerDal.List();
        }

        public void WriterAdd(Writer writer)
        {
            _witerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _witerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _witerDal.Update(writer);
        }
    }
}
