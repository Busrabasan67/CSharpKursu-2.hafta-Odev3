using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Category entity)
        {
            _categoryDal.TDelete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.TGetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.TGetId(id);
        }

        public void Insert(Category entity)
        {
            _categoryDal.TAdd(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.TUpdate(entity);
        }
    }
}
