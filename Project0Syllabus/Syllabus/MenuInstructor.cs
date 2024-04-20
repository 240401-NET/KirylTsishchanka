namespace Project1Syllabus;

public class MenuInstructor 
{   
    
    public static void PrintInstructorMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Display All Students");
        Console.WriteLine("2. Add student");
        Console.WriteLine("3. Find Student by Id");
        Console.WriteLine("Enter 0 to exit");
    }


    public static void InstructorChoice(int instructorInput)
    {
                switch (instructorInput)
                    {   
                    case 1: //Display all students
                    LogicInstructor.DisplayAllStudents();
                    break;

                    case 2: //Add a student
                    LogicInstructor.AddStudent();
                    break;
                
                    case 3: //Find student
                    LogicInstructor.FindStudentById();
                    break;

                    default:
                    Console.WriteLine("Invalid choice, please enter again!");
                    break;
                    }
                }
    
    

}