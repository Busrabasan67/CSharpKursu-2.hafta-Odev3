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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Delete(Instructor entity)
        {
            _instructorDal.TDelete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.TGetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.TGetId(id);
        }

        public void Insert(Instructor entity)
        {
            _instructorDal.TAdd(entity);    
        }

        public void Update(Instructor entity)
        {
            _instructorDal.TUpdate(entity);
        }
    }
}
