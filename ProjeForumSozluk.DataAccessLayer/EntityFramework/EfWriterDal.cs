using ProjeForumSozluk.DataAccessLayer.Abstract;
using ProjeForumSozluk.DataAccessLayer.Concrete.Repositories;
using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.DataAccessLayer.EntityFramework
{
    public class EfWriterDal:GenericRepository<Writer>,IWriterDal
    {
    }
}
