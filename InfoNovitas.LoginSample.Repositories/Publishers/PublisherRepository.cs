using System;
using System.Collections.Generic;
using System.Linq;
using InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Repositories.Publishers
{
    public class PublisherRepository : IPublisherRepository
    {
        public List<Publisher> FindAll()
        {
            using (var context = new eKnjiznicaDBEntities())
            {
                return context.PublisherEntities.ToList();
            }
        }

        public Publisher FindBy(int key)
        {
            using (var context = new eKnjiznicaDBEntities())
            {
                return context.PublisherEntities.FirstOrDefault(publisher => publisher.Id == key);
            }
        }

        #region Not Implemented
        public int Add(Publisher item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Publisher item)
        {
            throw new NotImplementedException();
        }

        public Publisher Save(Publisher item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
