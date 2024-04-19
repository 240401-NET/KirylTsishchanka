using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
using ModelsLayer;


namespace RepoLayer
{

        public interface IRepositoryClass
    {
        List<Student> GetStudentList();
        List<GradesForm> GetStudentList2();
        List<GradesForm> GetStudentList3();
        Student StudentRegistration(Student c);
        Student StudentLogin(Student c);
        GradesForm StudentGradesForm(GradesForm c);
        
    }

    public class RepositoryClass : IRepositoryClass
    {

        private readonly IMyLogger _logger;

        public RepositoryClass(IMyLogger logger)
        {
            _logger = logger;
        }

        public List<Student> GetStudentList()
        {
            
            //string connectionString=File.ReadAllText("connectionstring.txt");

            string PathToDb=File.ReadAllText("connectionstring.txt");

            SqlConnection conn = new SqlConnection(PathToDb);

            SqlCommand command = new SqlCommand($"SELECT * FROM P1RegistrationTest", conn);
            command.Connection.Open();
            SqlDataReader ret = command.ExecuteReader();

            List<Student> list = new List<Student>();
            while (ret.Read())
            {
                Student c = Mapper.DbToStudent(ret);
                list.Add(c);
            }
            return list;
        }

        public Student StudentRegistration(Student c)
        {
            string PathToDb=File.ReadAllText("connectionstring.txt");
            SqlConnection conn = new SqlConnection(PathToDb);





            SqlCommand command1 = new SqlCommand($"Select * from P1RegistrationTest where UserName =@username", conn);
            command1.Connection.Open();
            
            // add the parameters to the query - do this to prevent Sql Injection
            command1.Parameters.AddWithValue("@UserName", c.UserName);
            

            SqlDataAdapter da = new SqlDataAdapter(command1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count>0)
            {
                Console.WriteLine("That Username already exists");
                c.UserName="That Username already exists";

                
                return null;
                
                
            }
            else
            {
                SqlCommand command2 = new SqlCommand($"INSERT INTO P1RegistrationTest (UserName, UserPassword) VALUES (@UserName,@UserPassword);", conn);
                

                // add the parameters to the query - do this to prevent Sql Injection
                command2.Parameters.AddWithValue("@UserName", c.UserName);
                command2.Parameters.AddWithValue("@UserPassword", c.UserPassword);

                int rowsAffected = command2.ExecuteNonQuery();

                if (rowsAffected == 1)
                {
                    conn.Close();
                    c.UserPassword="*****";
                    return c;
                }
                else
                {
                    return null;
                }

                
                
            
            }



            
        }


        public Student StudentLogin(Student c)
        {
            string PathToDb=File.ReadAllText("connectionstring.txt");
            SqlConnection conn = new SqlConnection(PathToDb);



            SqlCommand command1 = new SqlCommand($"DELETE FROM P1RegistrationTest WHERE UserName=@UserName AND UserPassword=@UserPassword", conn);
            command1.Connection.Open();
            
            // add the parameters to the query - do this to prevent Sql Injection
            command1.Parameters.AddWithValue("@UserName", c.UserName);
            command1.Parameters.AddWithValue("@UserPassword", c.UserPassword);
            

            int rowsAffected = command1.ExecuteNonQuery();

            
            // verify that the query succeeded.
            if (rowsAffected >0)
            {
                
                SqlCommand command2 = new SqlCommand($"INSERT INTO P1RegistrationTest (UserName, UserPassword) VALUES (@UserName,@UserPassword);", conn);
                
                // add the parameters to the query - do this to prevent Sql Injection
                command2.Parameters.AddWithValue("@UserName", c.UserName);
                command2.Parameters.AddWithValue("@UserPassword", c.UserPassword); 
                command2.ExecuteNonQuery();  
                
                conn.Close();

                Console.WriteLine("Please submit your registration form");
                c.UserPassword="*****";
                
                return c;
            }
            else
            {
                Console.WriteLine("Wrong Username or Password");
                c.UserName="Wrong Username or Password";
                c.UserPassword="Wrong Username or Password";
                
                return null;
            }
        }


        public GradesForm StudentGradesForm(GradesForm c)
        {
            
            string PathToDb=File.ReadAllText("connectionstring.txt");
            SqlConnection conn = new SqlConnection(PathToDb);


            SqlCommand command = new SqlCommand($"INSERT INTO P1GradesFormTest (FirstName, LastName, UnderGrad, OldGrade, NewGrade, RDescription, RStatus) VALUES (@FirstName,@LastName, @ETitle, @RCategory, @TotalAmount, @RDescription, @RStatus);", conn);
            command.Connection.Open();
            
            // add the parameters to the query - do this to prevent Sql Injection
            command.Parameters.AddWithValue("@FirstName", c.FirstName);
            command.Parameters.AddWithValue("@LastName", c.LastName);
            command.Parameters.AddWithValue("@ETitle", c.UnderGrad);
            command.Parameters.AddWithValue("@RCategory", c.OldGrade);
            command.Parameters.AddWithValue("@TotalAmount", c.NewGrade);
            command.Parameters.AddWithValue("@RDescription", c.RDescription);
            command.Parameters.AddWithValue("@RStatus", c.RStatus);
            
            int rowsAffected;
            if (c.RStatus =="Pending")
                {rowsAffected = command.ExecuteNonQuery();}
            else
                {
                    rowsAffected=-1;
                    c.RStatus="Wrong Status";
                }

            // verify that the query succeeded.
            if (rowsAffected == 1)
            {
                conn.Close();
                return c;
            }
            else
            {
                return null;
            }
        }


        public List<GradesForm> GetStudentList2()
        {
            
            string PathToDb=File.ReadAllText("connectionstring.txt");
            SqlConnection conn = new SqlConnection(PathToDb);

            
            SqlCommand command = new SqlCommand($"SELECT * FROM P1GradesFormTest", conn);
            
            command.Connection.Open();
            SqlDataReader ret = command.ExecuteReader();

            List<GradesForm> list = new List<GradesForm>();
            while (ret.Read())
            {
                GradesForm c = Mapper2.DbToStudent(ret);
                list.Add(c);
            }
            return list;
        }




        public List<GradesForm> GetStudentList3()
        {
            
            string PathToDb=File.ReadAllText("connectionstring.txt");
            SqlConnection conn = new SqlConnection(PathToDb);

            SqlCommand command1 = new SqlCommand($"UPDATE P1GradesFormTest SET RStatus='Approved'", conn);
            
            command1.Connection.Open();
            SqlDataReader ret = command1.ExecuteReader();

            List<GradesForm> list = new List<GradesForm>();
            while (ret.Read())
            {
                GradesForm c = Mapper2.DbToStudent(ret);
                list.Add(c);
            }
            return list;
        }
       

    }












































}