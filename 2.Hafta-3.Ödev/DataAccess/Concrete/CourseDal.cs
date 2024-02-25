using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {

        public List<Course> Courses { get; set; }
        public CourseDal()
        {
            Course course = new Course()
            {              
                Id = 1,
                CourseName = "C# Kamp",
                Description="...",
                Price=0,
                CategoryId=1,
                InstructorId=1

            };
            Courses = new List<Course>() { course };
        }
        public void TAdd(Course entity)
        {
              Courses.Add(entity);
        }

        public void TDelete(Course entity)
        {
            Courses.Remove(entity);
        }

        public List<Course> TGetAll()
        {
            return Courses;
        }

        public Course TGetId(int id)
        {
            return Courses.FirstOrDefault(x => x.Id == id);
                     
        }

        public void TUpdate(Course entity)
        {
            var data= Courses.FirstOrDefault(x => x.Id == entity.Id);
            if (data != null) data = entity;
        }
    }
}
