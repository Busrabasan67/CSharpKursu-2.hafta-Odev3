using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> Categories { get; set; }
        public CategoryDal()
        {
            Category category = new Category()
            {
                CategoryName = "C#",
                Id=1
            };
            Category category2 = new Category()
            {
                CategoryName = "Angular",
                Id = 2
            };
          

            Categories = new List<Category>() { category, category2 };

        }

        public void TAdd(Category entity)
        {
            Categories.Add(entity);
        }

        public void TDelete(Category entity)
        {
            Categories.Remove(entity);
        }

        public Category TGetId(int id)
        {
             return Categories.FirstOrDefault(x => x.Id == id);
        }

        public List<Category> TGetAll()
        {
            return Categories;
        }

        public void TUpdate(Category entity)
        {           
                var data = Categories.FirstOrDefault(x => x.Id == entity.Id);
                if (data != null) data = entity;

        }
    }
}
