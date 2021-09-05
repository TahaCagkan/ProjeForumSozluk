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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactdal)
        {
            _contactDal = contactdal;
        }
        public void CategoryAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void CategoryDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void CategoryUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }
    }
}
