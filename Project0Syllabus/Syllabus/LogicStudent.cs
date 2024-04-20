using System.Runtime;
using System.Text.Json;
using System.Text.Json.Serialization; 

namespace Project1Syllabus;

public class LogicStudent
{

    public static double GradeCalculator(
    double attendance, 
    double quiz, 
    double midterm1, 
    double midterm2, 
    double finalExam)
    {
        double total=quiz*0.15+midterm1*0.25+midterm2*0.25+finalExam*0.35;
        
        return total;

    }

    public static double GradeCalculatorPlus(
    double attendance, 
    double quiz, 
    double midterm1, 
    double midterm2, 
    double finalExam)
    {
        double total=quiz*0.15+midterm1*0.25+midterm2*0.25+finalExam*0.35;
        total=total+Math.Min(10,attendance*(100-total)/400);

        return total;

    }

    public static string LetterGrade(double total)
    {
        string letterGrade="A";

        if(total>=93){letterGrade="A";}
        else if(total<93&&total>=90){letterGrade="A-";}
        else if(total<90&&total>=87){letterGrade="B+";}
        else if(total<87&&total>=83){letterGrade="B";}
        else if(total<83&&total>=80){letterGrade="B-";}
        else if(total<80&&total>=77){letterGrade="C+";}
        else if(total<77&&total>=73){letterGrade="C";}
        else if(total<73&&total>=70){letterGrade="C-";}
        else if(total<70&&total>=67){letterGrade="D+";}
        else if(total<67&&total>=63){letterGrade="D";}
        else if(total<63&&total>=60){letterGrade="D-";}
        else{letterGrade="F";}

        return letterGrade;

    }

    

    

    public static void CourseGradeDialogue()
    {

        double attendance; 
        double quiz; 
        double midterm1; 
        double midterm2; 
        double finalExam;
        double total;
        double totalPl;

        
        Console.Write("Enter your course attendance: ");
        attendance=Validation.userChoiceCheck();
        Console.Write("Enter your quizzes' average: ");
        quiz=Validation.userChoiceCheck();
        Console.Write("Enter your Midterm Exam 1: ");
        midterm1=Validation.userChoiceCheck();
        Console.Write("Enter your Midterm Exam 2: ");
        midterm2=Validation.userChoiceCheck();
        Console.Write("Enter your Final Exam: ");
        finalExam=Validation.userChoiceCheck();

        total=GradeCalculator(
        attendance, 
        quiz, 
        midterm1, 
        midterm2, 
        finalExam);

        totalPl=GradeCalculatorPlus(
        attendance, 
        quiz, 
        midterm1, 
        midterm2, 
        finalExam);

        Console.WriteLine("**************************************************");
        Console.WriteLine("Your Course Grade is "+total);
        Console.WriteLine("Your Course Grade (curved) is "+totalPl);
        Console.WriteLine("Your Course Letter Grade is "+LetterGrade(totalPl));
        Console.WriteLine("**************************************************");

        List<ClassGrades> gradeList = new();
        Data.LoadGrades(ref gradeList);

        ClassGrades studentGrades = new(attendance, quiz,midterm1, midterm2, finalExam, total, totalPl, LetterGrade(totalPl));
        
        gradeList.Add(studentGrades);
        Data.PersistGrades(gradeList);
         

    }

    public static void DisplayGeneratedGrades()
    {

        try{
            string filePath = "gradeList.json";
            string jsonGrades = File.ReadAllText(filePath);

            List<ClassGrades> grades = JsonSerializer.Deserialize<List<ClassGrades>>(jsonGrades);
            
            foreach(ClassGrades grade in grades){
                Console.WriteLine(grade.ToString());
            }

        }catch(Exception){
            Console.WriteLine("There are no generated grades!");
        }

    }


    public static void EraseGeneratedGrades(){

        //try{
            string filePath = "gradeList.json";
            
            File.Delete(filePath);

        //}catch(Exception){
            //Console.WriteLine("There are no generated grades!");
        //}

        Console.WriteLine("All generated grades have been erased.");

    }

    public static void ShowMyCurrentGrades()
    {

        int idNumber=-1;
        string lastName;
        string firstName;
    

        while(idNumber==-1)
        {
            Console.Write("Enter your ID number: ");
            idNumber=Validation.userChoiceToInt();
        }
        Console.Write("Enter your Last Name: ");
        lastName=Console.ReadLine();
        Console.Write("Enter your First Name: ");
        firstName=Console.ReadLine();

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
                if(student.idNumber==idNumber&&student.lastName==lastName&&student.firstName==firstName)
                    {
                        Console.WriteLine("**************************************************");
                        Console.WriteLine(student);
                        tst++;
                    }
                }

            if(tst==0)
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("User not found");
                    Console.WriteLine("**************************************************");
                }
            

        }catch(Exception e){
            Console.WriteLine("File not generated, first time execution!");
        }





    }

    
    











}

