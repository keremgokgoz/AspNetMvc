﻿using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
   public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category>GetAll()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName==""||p.CategoryName.Length<3||p.CategoryDescription=="")
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