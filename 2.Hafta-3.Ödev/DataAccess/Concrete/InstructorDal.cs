using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        public List<Instructor> Instructors { get; set; }
        public InstructorDal() 
        { 
          Instructor instructor = new Instructor()
          {
              FirstName="Engin",
              LastName= "Demirog",
              Email="engindemirog@gmail.com",
              Id=1,

          };
            Instructors=new List<Instructor>() { instructor};
        }

        public void TAdd(Instructor entity)
        {
            Instructors.Add(entity);
        }

        public void TDelete(Instructor entity)
        {
            Instructors.Remove(entity);
        }

        public List<Instructor> TGetAll()
        {
            return Instructors;
        }

        public Instructor TGetId(int id)
        {
            return Instructors.FirstOrDefault(x=>x.Id==id);
        }

        public void TUpdate(Instructor entity)
        {
           var data=Instructors.FirstOrDefault(x=>x.Id==entity.Id);
            if (data != null) data = entity;
        }
    }
}
