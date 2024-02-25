using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Delete(Course entity)
        {
            _courseDal.TDelete(entity);
        }

        public List<Course> GetAll()
        {
           return _courseDal.TGetAll();
        }

        public Course GetById(int id)
        {
           return _courseDal.TGetId(id);
        }

        public void Insert(Course entity)
        {
            _courseDal.TAdd(entity);
        }

        public void Update(Course entity)
        {
            _courseDal.TUpdate(entity);
        }
    }
}
