namespace StudentInfoSystem;

public class Student
{
    public string name;
    public string middleName;
    public string lastName;
    public string faculty;
    public string specialty;
    public string education;
    public string status;
    public int facultyNumber;
    public string course;
    public string stream;
    public string group;

    public Student()
    {
    }

    public Student(string name, string middleName, string lastName, string faculty, string specialty, string education, string status, int facultyNumber, string course, string stream, string group)
    {
        this.name = name;
        this.middleName = middleName;
        this.lastName = lastName;
        this.faculty = faculty;
        this.specialty = specialty;
        this.education = education;
        this.status = status;
        this.facultyNumber = facultyNumber;
        this.course = course;
        this.stream = stream;
        this.group = group;
    }
}