using System.Collections.Generic;
using UserLogin;

namespace StudentInfoSystem;

public class StudentData
{
    private static List<Student> testStudents { get; }

    public static List<Student> testStudentsData()
    {
        List<Student> result = new List<Student>();
        result.Add(new Student("Dimitar", "Angelov", "Dimitrov",
            "FKST", "KSI", "mats", "ACTIVE", 1212201,
            "3", "10", "46"));
        return result;
    }
    
    
}