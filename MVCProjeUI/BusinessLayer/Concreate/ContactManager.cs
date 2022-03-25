using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ContactManager
    {
        GenericRepository<Contact> repo = new GenericRepository<Contact>();
        public List<Contact> GetAll()
        {
            return repo.List();
        }

        public void ContactAddBL(Contact p)
        {
            if (p.Username == "" || p.Usermail=="")
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
