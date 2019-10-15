using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class StudentDAL2
    {
        myContext db = new myContext();

        const int PageSize = 3;

        public List<Student> Search(string search, int page = 1)

        {

            var List = db.Students.ToList();

            if (!string.IsNullOrWhiteSpace(search))
            {
                List = db.Students.Where(x => x.F_Name .Contains(search) ||  search == null)
               .OrderBy(x => x.StudentId)
               .Skip((page - 1) * PageSize)
               .Take(PageSize).ToList();


                var Totalpages = Math.Ceiling((double)List.Count() / PageSize);
                var CurrentPage = page;

                var TotalPages = Totalpages;

            }

            return (List);

        }
        

        public List<Student> Get()
        {
            var Result = db.Students.ToList();
            //var Result = Get();
            return Result;
        }

        public Student GetByID(int Id)
        {
            var std = db.Students.Where(s => s.StudentId == Id).Single();
            return std;
        }

        public Student Add(Student std )
        { 
                db.Students.Add(std);
                db.SaveChanges();
                 return std;
        }

        public Student Edit(Student std)
        {
            var stdOld = db.Students.Where(s => s.StudentId == std.StudentId).Single();
            stdOld.F_Name = std.F_Name;
            stdOld.M_Name = std.M_Name;
            stdOld.L_Name = std.L_Name;
            stdOld.Age = std.Age;
            stdOld.Email = std.Email;
            stdOld.gender= std.gender;

            //stdOld.CreationData = std.CreationData;
            stdOld.DOB = std.DOB;
            stdOld.Active = std.Active;
            db.SaveChanges();
            return std;
        }
        public Student Delete(int Id)
        {
            var std = db.Students.Where(s => s.StudentId == Id).Single();
            db.Students.Remove(std);
            db.SaveChanges();
            return std;
        }

    }

}


