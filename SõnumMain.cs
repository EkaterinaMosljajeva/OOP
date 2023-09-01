public class Program
{
    public static void Main()
    {
        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
        m1.ShowMessage();
        m1.AddLike();
        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
        m2.ShowMessage();
        m2.AddLike();
        Console.WriteLine(m1.PopVsPop(m1, m2));
    }
}
