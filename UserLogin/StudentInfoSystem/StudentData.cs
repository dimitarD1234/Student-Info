using System.Collections.Generic;
using System.Linq;
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
        result.Add(new Student("Angel", "Angelov", "Angelov",
           "FKST", "KSI", "mats", "ACTIVE", 1212201,
           "3", "10", "46"));
        return result;
    }

    public bool TestStudentsIfEmpty()
    {
        StudentInfoContext context = new StudentInfoContext();
        IEnumerable<Student> queryStudents = context.Students;
        int countStudents = queryStudents.Count();


        return countStudents > 0 ? true : false;
    }

   public void CopyTestStudents()
    {
        StudentInfoContext context = new StudentInfoContext();
        foreach (Student st in testStudents)
        {
            context.Students.Add(st);
        }
        context.SaveChanges();
    }

    private static List<Student> GetRegions()
    {
        StudentInfoContext context = new StudentInfoContext();
        List<Student> students = context.Students.ToList();
        return students;
    }


}