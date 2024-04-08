namespace Project1Syllabus;

public class ClassGrades 
{   // Fields/properties
    //shorthand to avoid getters and setters
    public double? attendance {get; set;}
    public double? quiz {get; set;}
    public double? midterm1 {get; set;}
    public double? midterm2 {get; set;}
    public double? finalExam {get; set;}
    public double? total {get; set;}
    public double? totalPl {get; set;}
    public string? letterGrade {get; set;}
    
    //Constructors
    
    //No argument constructor
    public ClassGrades() {}

    //Constructor with arguments
    public ClassGrades(
    double attendance, 
    double quiz, 
    double midterm1, 
    double midterm2,
    double finalExam, 
    double total,
    double totalPl,
    string letterGrade
    ){
        this.attendance = attendance;
        this.quiz = quiz;
        this.midterm1 = midterm1;
        this.midterm2 = midterm2;
        this.finalExam = finalExam;
        this.total = total;
        this.totalPl = totalPl;
        this.letterGrade = letterGrade;
    }

    //Overriding a method, in this case toString()
    public override string ToString()
    {
        return "Attendance: "+attendance+"% Quiz: "+quiz+"% Midterm 1: "+midterm1
        +"% Midterm 2: "+midterm2+"% Final Exam: "+finalExam
        +"% Total: "+total+"% Total Plus: "+totalPl+"% Letter Grade: "+letterGrade;
    }


}