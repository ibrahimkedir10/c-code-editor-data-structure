public class MyClass : IStudent, ITeacher
{
    public void Study()
    {
        Console.WriteLine("Student is studying.");
    }

    public void Teach()
    {
        Console.WriteLine("Teacher is teaching.");
    }
}
