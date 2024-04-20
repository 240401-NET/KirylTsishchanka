using System.Runtime;
using System.Text.Json;
using System.Text.Json.Serialization; 

namespace Project1Syllabus;

public class LogicInstructor 
{
    
    public static void DisplayAllStudents(){

        try{
            string filePath = "studentList.json";
            string jsonStudents = File.ReadAllText(filePath);

            List<ClassStudents> students = JsonSerializer.Deserialize<List<ClassStudents>>(jsonStudents);

            foreach(ClassStudents student in students){
                Console.WriteLine(student.ToString());
            }

        }catch(Exception){
            Console.WriteLine("There are no students!");
        }

    }


    public static void AddStudent(){
        ClassStudents newStudent = new();
        
        Console.WriteLine("Id number");
        
        newStudent.idNumber = Validation.userChoiceToInt();

        Console.WriteLine("Last Name");
        
        newStudent.lastName = Console.ReadLine();

        Console.WriteLine("First Name");
        
        newStudent.firstName = Console.ReadLine();

        Console.WriteLine("Attendance");
        
        newStudent.attendance = Validation.userChoiceCheck();
        double at=newStudent.attendance;
        
        Console.WriteLine("Quiz");
        
        newStudent.quiz = Validation.userChoiceCheck();
        double qz=newStudent.quiz;
        
        Console.WriteLine("Midterm 1");
        
        newStudent.midterm1 = Validation.userChoiceCheck();
        double m1=newStudent.midterm1;
        
        Console.WriteLine("Midterm 2");
        
        newStudent.midterm2 = Validation.userChoiceCheck();
        double m2=newStudent.midterm2;
        
        Console.WriteLine("Final Exam");
        
        newStudent.finalExam = Validation.userChoiceCheck();
        double fn=newStudent.finalExam;
        
        //Console.WriteLine("Total");
        
        //newStudent.total = Validation.userChoiceCheck();
        newStudent.total = LogicStudent.GradeCalculatorPlus(at, qz, m1, m2, fn);

        //Console.WriteLine("Letter grade");
        
        //newStudent.letterGrade = Console.ReadLine();
        newStudent.letterGrade = LogicStudent.LetterGrade(LogicStudent.GradeCalculatorPlus(at, qz, m1, m2, fn));

        List<ClassStudents> studentList = new();
        Data.LoadStudents(ref studentList);
        
        studentList.Add(newStudent);
        Data.PersistStudents(studentList);

    }


    


    public static void FindStudentById()
    {

        int idNumber=-1;
        

        while(idNumber==-1)
        {
            Console.Write("Enter student's ID number: ");
            idNumber=Validation.userChoiceToInt();
        }
        
        try{
            string filePath = "studentList.json";
            string jsonStudents = File.ReadAllText(filePath);

            
            var serializationOptions = new JsonSerializerOptions
            {
            //PropertyNameCaseInsensitive = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            List<ClassStudents> students = JsonSerializer.Deserialize<List<ClassStudents>>(jsonStudents,serializationOptions);
            
            int tst=0;

            foreach(ClassStudents student in students){
                if(student.idNumber==idNumber)
                    {
                        Console.WriteLine("**************************************************");
                        Console.WriteLine(student);
                        Console.WriteLine("**************************************************");
                        tst++;
                    }
                }

            if(tst==0)
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Student not found");
                    Console.WriteLine("**************************************************");
                        
                }
            

        }catch(Exception e){
            Console.WriteLine("File not generated, first time execution!");
        }





    }

    
}