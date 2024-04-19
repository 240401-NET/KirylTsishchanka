using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Project1Syllabus;

public class Program
{
    static void Main(string[] args)
    {
        
        string connectionString="Server=tcp:tkirylpr1.database.windows.net,1433;Initial Catalog=ktProject1net;Persist Security Info=False;User ID=kiryl;Password=Kitdb2024!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        var optionsBuilder=new DbContextOptionsBuilder<KtProject1netContext>();
        optionsBuilder.UseSqlServer(connectionString);

        KtProject1netContext context = new KtProject1netContext(optionsBuilder.Options);

        IEnumerable<DbStudent> customers=context.DbStudents;

        Console.WriteLine("There are "+customers.Count()+" students in the group.");
        
        
        
        
        int userInput = -1;
        int studentInput = -1;
        int instructorInput = -1;

        MenuMain.PrintMainMenu();

        // Create Switch Menu inside while loop w/user input
        while (userInput != 0)
        {
            //Store that input into userInput
            userInput = Validation.userChoiceToInt();

            //Switch upon the user input
            switch (userInput)
            {   
                //Execute code based on whatever case we enter
                
                case 1: 
                while (instructorInput != 0)
                {
                MenuInstructor.PrintInstructorMenu();
                instructorInput = Validation.userChoiceToInt();

                if (instructorInput==0) userInput=instructorInput;
                else MenuInstructor.InstructorChoice(instructorInput);
                }
                break;
                
                case 2: 
                while (studentInput != 0)
                {
                MenuStudent.PrintStudentMenu();
                studentInput = Validation.userChoiceToInt();

                if (studentInput==0) userInput=studentInput;
                else MenuStudent.StudentChoice(studentInput);
                }
                break;


                //If user enters 0 we exit the switch and the program ends
                case 0:
                Console.WriteLine("Goodbye!");    
                break;

                default:
                Console.WriteLine("Invalid choice, please enter again!");
                break;
            }

        }




    }



}
