public class Message
{
    private readonly string _content;
    private readonly string _author;
    private readonly DateTime _time;
    private int _likes;

    public Message(string content, string author, DateTime time)
    {
        this._content = content;
        this._author = author;
        this._time = time;
    }

    public int Likes { get => _likes; }
    public DateTime Time { get => _time; }
    public string Author { get => _author; }
    public string Content { get => _content; }

    public void AddLike()
    {
        _likes++;
    }

    public double GetPopularity()
    {
        double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
        if (elapsed == 0)
        {
            return _likes;
        }
        return _likes / elapsed;

    }

    public void ShowMessage()
    {
        Console.WriteLine("{0}/{1}\n{2}", Author, Time, Content);

    }

    public string PopVsPop(Message esimene, Message teine)
    {
        double esimenePop=Math.Round(esimene.GetPopularity(),2);
        double teinePop = Math.Round(teine.GetPopularity(), 2);
        string rezult = "";
        Console.WriteLine("{0} ja {1}", esimenePop, teinePop);
        if (esimenePop > teinePop) { rezult = "Esimene sõnum on populaarsem kui teine"; }
        else if (esimenePop < teinePop) { rezult = "Teine sõnum on populaarsem kui esimene"; }
        else { rezult = "Sõnumid on võrdselt populaarsed"; }

        return rezult;
    }
}
