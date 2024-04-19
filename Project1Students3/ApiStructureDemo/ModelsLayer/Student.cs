using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Student
    {
        public Student()
        {
        }

        public Student(int StudentId, string username, string userpassword)
        {
            StudentId = StudentId;
            UserName=username;
            UserPassword=userpassword;
            
        }

        

        public int StudentId { get; set; }

        [JsonPropertyName("username")]
        [StringLength(50, ErrorMessage = "That User Name is too long or too short. It should be at least 5 and at most 50 characters long.", MinimumLength = 5)]

        public string UserName { get; set; }
        
        [JsonPropertyName("userpassword")]
        [StringLength(20, ErrorMessage = "That Password is too long or too short. It should be at least 5 and at most 20 characters long.", MinimumLength = 5)]

        public string UserPassword { get; set; }

        
        
    }




    public class GradesForm
    {
        public GradesForm()
        {
        }

        public GradesForm(int gradesFormId, string firstName, string lastName, string underGrad, string oldGrade, string newGrade, string rDescription, string rStatus)
        {
            GradesFormId = gradesFormId;
            FirstName = firstName;
            LastName = lastName;
            UnderGrad = underGrad;
            OldGrade = oldGrade;
            NewGrade = newGrade;
            RDescription=rDescription;
            RStatus=rStatus;
            
        }

        

        public int GradesFormId { get; set; }

        [JsonPropertyName("firstName")]
        [StringLength(20, ErrorMessage = "That First Name is too long or too short. It should be at least 2 and at most 30 characters long.", MinimumLength = 2)]

        public string FirstName { get; set; }
        
        [JsonPropertyName("lastName")]
        [StringLength(50, ErrorMessage = "That Last Name is too long or too short. It should be at least 2 and at most 30 characters long.", MinimumLength = 2)]

        public string LastName { get; set; }

        [JsonPropertyName("underGrad")]
        [StringLength(10, ErrorMessage = "That Title is too long or too short. It should be at least 2 and at most 10 characters long.", MinimumLength = 2)]

        public string UnderGrad { get; set; }

        [JsonPropertyName("oldGrade")]
        [StringLength(2, ErrorMessage = "That Category is too long or too short. It should be at least 1 and at most 2 characters long.", MinimumLength = 2)]

        public string OldGrade { get; set; }

        public string NewGrade { get; set; }

        public string RDescription { get; set; }
        public string RStatus { get; set; }
        
        
    }




}