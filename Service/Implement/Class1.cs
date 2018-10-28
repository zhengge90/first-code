using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Implement
{
    class Class1 : ICategoryManager
    {
        public IList<Domain.Category> LoadAllByPage(out long total, int page, int rows, string order, string sort)
        {
            throw new NotImplementedException();
        }

        public IList<Domain.Category> LoadAllEnable()
        {
            return null;
        }

        public IList<Domain.Category> LoadAllEnable(Guid forumId)
        {
            throw new NotImplementedException();
        }

        public Domain.Category Get(object id)
        {
            throw new NotImplementedException();
        }

        public Domain.Category Load(object id)
        {
            throw new NotImplementedException();
        }

        public object Save(Domain.Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Category entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(Domain.Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(IList<object> idList)
        {
            throw new NotImplementedException();
        }

        public IList<Domain.Category> LoadAll()
        {
            throw new NotImplementedException();
        }

        public IList<Domain.Category> LoadAllWithPage(out long count, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
