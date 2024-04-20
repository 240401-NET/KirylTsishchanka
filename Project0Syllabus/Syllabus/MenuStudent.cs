using System.Security.Cryptography.X509Certificates;

namespace Project1Syllabus;

public class MenuStudent 
{   
    

    public static void PrintStudentMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. General Information");
        Console.WriteLine("2. Office Hours");
        Console.WriteLine("3. Course Website");
        Console.WriteLine("4. Textbook");
        Console.WriteLine("5. Prerequisites");
        Console.WriteLine("6. Quizzes");
        Console.WriteLine("7. Exams");
        Console.WriteLine("8. Grading");
        Console.WriteLine("9. Grade Calculator");
        Console.WriteLine("10. Display Generated Grades");
        Console.WriteLine("11. Erase All Generated Grades");
        Console.WriteLine("12. Show My Current Grades");
        Console.WriteLine("Enter 0 to exit");
    }


    public static void StudentChoice(int studentInput)
    {
    
                    
                    //Switch upon the user input
                    switch (studentInput)
                    {   
                    //Execute code based on whatever case we enter
                    
                    case 1:
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Semester: Fall 2021");
                    Console.WriteLine("Course: MATH 427J (55345): Differential Equations and Linear Algebra");
                    Console.WriteLine("Class meetings: MWF 1:00pm - 2:00pm in RLP 0.130");
                    Console.WriteLine("Discussions: TTH 8:30am - 9:30am in CPE 2.208");
                    Console.WriteLine("Instructor: Kiryl Tsishchanka");
                    Console.WriteLine("E-mail address: kit@math.utexas.edu");
                    Console.WriteLine("**************************************************");
                    break;

                    case 2:
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Office hours: MWF 11:00am - 12:00pm or by appointment");
                    Console.WriteLine("**************************************************");
                    break;
                

                    case 3: 
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Website: Course syllabus, calendar, lecture notes, practice tests, etc. can be found here");
                    Console.WriteLine("web.ma.utexas.edu/users/kit/differential equations and linear algebra.html");
                    Console.WriteLine("**************************************************");
                    break;
                

                    case 4: 
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Textbook: Differential Equations and Their Applications by Martin Braun");
                    Console.WriteLine("**************************************************");
                    break;
                

                    case 5: 
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Prerequisites: The prerequisite is one of M408D, M408L, M408S or the equivalent, with a grade of at least C-.");
                    Console.WriteLine("**************************************************");
                    break;
                

                    case 6: 
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Quizzes: Quizzes will be given every week on Thursdays during discussion sessions."); 
                    Console.WriteLine("One lowest quiz score will be dropped at the end of the semester."); 
                    Console.WriteLine("**************************************************");
                    break;
                
                    case 7: 
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Exams: There will be two 50 min. midterm exams (October 1, November 12) and the final exam (Monday, December 13, 2:00pm - 5:00pm)."); 
                    Console.WriteLine("**************************************************");
                    break;
                

                    case 8: 
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Grading: To compute your final course grade, I will average your quizzes (15%), midterm exams (25% each) and the final exam (35%).");
                    Console.WriteLine("You are guaranteed the following cutoffs:");
                    Console.WriteLine("93   A");
                    Console.WriteLine("90   A-");
                    Console.WriteLine("87   B+");
                    Console.WriteLine("83   B");
                    Console.WriteLine("80   B-");
                    Console.WriteLine("77   C+");
                    Console.WriteLine("73   C");
                    Console.WriteLine("70   C");
                    Console.WriteLine("60   D");
                    Console.WriteLine("A curve will be applied at the end of the semester. For more information, see Grade Calculator.");
                    Console.WriteLine("**************************************************");
                    break;
                

                    case 9: 
                    Console.WriteLine("**************************************************");
                    LogicStudent.CourseGradeDialogue();
                    break;
                    
                    case 10: 
                    Console.WriteLine("**************************************************");
                    LogicStudent.DisplayGeneratedGrades();
                    Console.WriteLine("**************************************************");
                    break;

                    case 11: 
                    Console.WriteLine("**************************************************");
                    LogicStudent.EraseGeneratedGrades();
                    Console.WriteLine("**************************************************");
                    break;

                    case 12: 
                    Console.WriteLine("**************************************************");
                    LogicStudent.ShowMyCurrentGrades();
                    Console.WriteLine("**************************************************");
                    break;
                    
                    
                    
                    default:
                    Console.WriteLine("Invalid choice, please enter again!");
                    break;
                    }
    }

    

}