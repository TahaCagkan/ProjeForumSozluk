﻿using ProjeForumSozluk.BusinessLayer.Abstract;
using ProjeForumSozluk.DataAccessLayer.Abstract;
using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {

        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public void ContentAdd(Content category)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content category)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content category)
        {
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }
    }
}