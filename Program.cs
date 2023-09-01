//public class Student
//{
//    public string Name { get; }
//    public int age;
//    private readonly string _city;
//    public string status;
//    public int year;

//    public Student(string name, int age, string city)
//    {
//        Name = name;
//        Age = age;
//        _city = city;
//    }
//    public int Age 
//    {
//        get { return age; }
//        set
//        {
//            age = value;
//            if (age < 18) status = "alaealine";
//            else status = "täiskasvanud";
//        }
//    }
//    public string Status 
//    {
//        get { return status; }
//    }
//    public string GetCity()
//    {
//        return _city;
//    }
//    public int Year
//    {
//        get { return year; }
//        set
//        {
//            age = value;
//            year = 
//        }
//    }
//    public void ShowInfo()
//    {
//        Console.WriteLine(Name);
//        Console.WriteLine(Age);
//        Console.WriteLine(GetCity());
//    }
//}

//public class StudentMain
//{
//    public static void Main()
//    {
//        Student student = new Student("John", 17, "London");

//        student.ShowInfo();
//        //Console.WriteLine(student.Name);
//        //Console.WriteLine(student.Age);
//        //Console.WriteLine(student.GetCity());
//    }
//}