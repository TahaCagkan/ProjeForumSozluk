using ProjeForumSozluk.BusinessLayer.Abstract;
using ProjeForumSozluk.DataAccessLayer.Abstract;
using ProjeForumSozluk.DataAccessLayer.Concrete.Repositories;
using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoruService
    {
        
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }


    }
}
