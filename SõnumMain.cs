using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Message> list = new List<Message>();
        Random rnd = new Random();
        int MCount = rnd.Next(2, 3);
        for (int i = 0; i < MCount; i++)
        {
            Message message = new Message();
            message = message.CreateMessages();
            list.Add(message);
            message.ShowMessage();
        }

        Console.WriteLine(list[0].PopVsPopN(list));
    }
}