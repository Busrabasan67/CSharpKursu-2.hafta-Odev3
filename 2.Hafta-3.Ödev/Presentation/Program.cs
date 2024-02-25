using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Concretes;

ICategoryService _categoryService = new CategoryManager(new CategoryDal());
IInstructorService _instructorService=new InstructorManager(new InstructorDal());
ICourseService _courseService=new CourseManager(new CourseDal());

#region Category
Category category = new Category() { Id = _categoryService.GetAll().Count() + 1, CategoryName = "C++" };

_categoryService.Insert(category);

foreach (var item in _categoryService.GetAll())
{
    Console.WriteLine(item.CategoryName);
}

Category oldCategory = _categoryService.GetById(2);

oldCategory.CategoryName = "YeniKategori";
_categoryService.Update(oldCategory);

_categoryService.Delete(_categoryService.GetById(3));

#endregion

#region Instructor
Instructor instructor = new Instructor() { Email="Deneme",FirstName="Gençay",LastName="Yıldız",Id=_instructorService.GetAll().Count()+1};
_instructorService.Insert(instructor);

foreach (var item in _instructorService.GetAll())
{
    Console.WriteLine($"Öğretmen: {item.FirstName + " " + item.LastName} Mail: {item.Email}");
}

Instructor oldInstructor = _instructorService.GetById(2);
oldInstructor.Email = "gencayyildiz@gmail.com";
_instructorService.Update(oldInstructor);

_instructorService.Delete(_instructorService.GetById(1));

#endregion

#region Course

Course course = new Course()
{
    Id = _courseService.GetAll().Count()+1,
    CourseName = "Angular Eğitim Kursu",
    CategoryId = 2,
    Description = "...",
    InstructorId = 2,
    Price = 100
};
_courseService.Insert(course);

foreach (var item in _courseService.GetAll())
{
    Console.WriteLine($"Kurs adı: {item.CourseName} Açıklama: {item.Description} Fiyatı: {item.Price}");
}

Course oldCourse= _courseService.GetById(2);
oldCourse.Description = "Derinlemesine Angular anlatımı.";
oldCourse.Price = 0;
_courseService.Update(oldCourse);

_courseService.Delete(_courseService.GetById(1));

#endregion



