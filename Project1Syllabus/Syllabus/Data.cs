namespace Project1Syllabus;

using System.IO;
using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Text.Json.Serialization; 


class Data 
{

    //Read the file
    public static void LoadStudents(ref List<ClassStudents> students){

        try{
            string filePath = "studentList.json";
            string jsonStudents = File.ReadAllText(filePath);

            var serializationOptions = new JsonSerializerOptions
            {
            NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            students = JsonSerializer.Deserialize<List<ClassStudents>>(jsonStudents,serializationOptions);
            
            foreach(ClassStudents student in students){
                student.ToString();
            }

        }catch(Exception e){
            Console.WriteLine("File not generated, first time execution!");
        }

    }

public static void LoadGrades(ref List<ClassGrades> gradeList){

        try{
            string filePath = "gradeList.json";
            string jsonStudentGrades = File.ReadAllText(filePath);

            gradeList = JsonSerializer.Deserialize<List<ClassGrades>>(jsonStudentGrades);
            
            foreach(ClassGrades gradelist in gradeList){
                gradelist.ToString();
            }

        }catch(Exception e){
            Console.WriteLine("File not generated, first time execution!");
        }

    }


    //Write to the file
    public static void PersistStudents(List<ClassStudents> students){

        //Serializing the list of ClassStudent objects to a JSON string
        string jsonStudents = JsonSerializer.Serialize(students);

        string filePath = "studentList.json";

        File.WriteAllText(filePath, jsonStudents);

    }

    //Write to the file
    public static void PersistGrades(List<ClassGrades> gradeList){

        //Serializing the list of ClassGrades objects to a JSON string
        string jsonGradeList = JsonSerializer.Serialize(gradeList);

        string filePath = "gradeList.json";
        
        File.WriteAllText(filePath, jsonGradeList);
        
    }

    




}