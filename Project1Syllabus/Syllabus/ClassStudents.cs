namespace Project1Syllabus;

public class ClassStudents 
{   // Fields/properties
    //shorthand to avoid getters and setters
    public int idNumber {get; set;}
    public string lastName {get; set;}
    public string firstName {get; set;}
    public double attendance {get; set;}
    public double quiz {get; set;}
    public double midterm1 {get; set;}
    public double midterm2 {get; set;}
    public double finalExam {get; set;}
    public double total {get; set;}
    public string letterGrade {get; set;}
    
    //Constructors
    
    //No argument constructor
    public ClassStudents() {}

    //Constructor with arguments
    public ClassStudents(
    int idNumber,
    string lastName,
    string firstName,
    double attendance, 
    double quiz, 
    double midterm1, 
    double midterm2,
    double finalExam, 
    double total,
    string letterGrade
    ){
        this.idNumber = idNumber;
        this.lastName = lastName;
        this.firstName = firstName;
        this.attendance = attendance;
        this.quiz = quiz;
        this.midterm1 = midterm1;
        this.midterm2 = midterm2;
        this.finalExam = finalExam;
        this.total = total;
        this.letterGrade = letterGrade;
    }

    //Overriding a method, in this case toString()
    public override string ToString()
    {
        return "Id Number: " + idNumber
        + " Last name: "
        + lastName
        + " First name: " 
        + firstName
        + " Attendance: " 
        + attendance
        + " Quiz: " 
        + quiz
        + " Midterm 1: " 
        + midterm1
        + " Midterm 2: " 
        + midterm2
        + " Final Exam: " 
        + finalExam
        + " Total: " 
        + total
        + " Letter Grade: " 
        + letterGrade;
    }






}