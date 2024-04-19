using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{
    public interface IBusinessLayerClass
    {
        List<Student> GetStudentList();
        List<GradesForm> GetStudentList2();
        List<GradesForm> GetStudentList3();
        Student StudentRegistration(Student c);
        Student StudentLogin(Student c);
        GradesForm StudentGradesForm(GradesForm c);
        
    }

    public class BusinessLayerClass : IBusinessLayerClass
    {
        private readonly IRepositoryClass _repo;

        public BusinessLayerClass(IRepositoryClass repo)
        {
            _repo = repo;
        }


        public List<Student> GetStudentList()
        {
            // call the repo method to get the list.
            List<Student> l = this._repo.GetStudentList();
            

            //LINQ
            List<Student> l2 = l.Where(x => x.UserName == "Tsishchanka" && x.UserPassword.Contains("some remarks")).ToList();// write a 'Predicate' into the arg of the method. 
            List<Student> l3 = l.OrderByDescending(x => x.StudentId).ToList();
            foreach (Student c in l3)
            {
                 Console.WriteLine($"StudentId - {c.StudentId}, Fname- {c.UserName}, lname -  {c.UserPassword}");
            }

             return l;
        }

        public List<GradesForm> GetStudentList2()
        {
            // call the repo method to get the list.
            List<GradesForm> l = this._repo.GetStudentList2();
            

            return l;
        }

        public List<GradesForm> GetStudentList3()
        {
            // call the repo method to get the list.
            List<GradesForm> l = this._repo.GetStudentList3();
            

            return l;
        }

        public Student StudentRegistration(Student c)
        {
            Student c1 = this._repo.StudentRegistration(c);
            return c1;
        }

        public Student StudentLogin(Student c)
        {
            Student c1 = this._repo.StudentLogin(c);
            return c1;
        }

        public GradesForm StudentGradesForm(GradesForm c)
        {
            GradesForm c1 = this._repo.StudentGradesForm(c);
            return c1;
        }

    
    }
}