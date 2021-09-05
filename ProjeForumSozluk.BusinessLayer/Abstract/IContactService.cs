using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        void CategoryAdd(Contact contact);
        Contact GetById(int id);
        void CategoryDelete(Contact contact);
        void CategoryUpdate(Contact contact);
    }
}
