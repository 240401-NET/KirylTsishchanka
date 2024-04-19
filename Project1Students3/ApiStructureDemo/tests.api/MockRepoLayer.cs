using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace tests.api
{
    public class MockRepoLayer : IRepositoryClass
    {
        public List<Student> GetStudentList()
        {
            Student c1 = new Student(1, "m1", "m1");
            Student c2 = new Student(1, "m2", "m2");
            List<Student> list = new List<Student>() { c1, c2};
            return list;

        }

        public List<GradesForm> GetStudentList2()
        {
            throw new NotImplementedException();

        }

        public List<GradesForm> GetStudentList3()
        {
            throw new NotImplementedException();

        }

        public Student StudentRegistration(Student c)
        {
            throw new NotImplementedException();
        }

        public Student StudentLogin(Student c)
        {
            throw new NotImplementedException();
        }

        public GradesForm StudentGradesForm(GradesForm c)
        {
            throw new NotImplementedException();
        }

        


    }
}