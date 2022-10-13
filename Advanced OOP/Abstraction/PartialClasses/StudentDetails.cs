namespace PartialClasses;

public enum Gender { Default, Male, Female, Others }
public enum Department { Default, EEE, CSE, ECE }
public partial class StudentDetails
{
    private static int s_studentID = 1000;

    public string StudentID { get; set; }

    public Department Department { get; set; }

    public string Year { get; set; }

    public int Physics { get; set; }  // Property declaration only allowed

    public int Chemistry { get; set; }

    public int Maths { get; set; }

    public int Total { get; set; }

    public double Average { get; set; }
}
