using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.BusinessLayer.Abstract
{
    public interface ICategoruService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);

    }
}
