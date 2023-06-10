class Piece : IDisposable, IPieceInfo
{
    public string PieceName { get; set; }
    public string AutorName { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public Piece(string pieceName, string autorName, string genre, int year)
    {
        PieceName = pieceName;
        AutorName = autorName;
        Genre = genre;
        Year = year;
    }
    public void Start() => Console.WriteLine("Трансляция пьесы началась");

    public void Stop() => Console.WriteLine("Трансляция пьесы приостановлена");

    public void End() => Console.WriteLine("Трансляция пьесы закончилась");
    public string GetInfo()
    {
        Console.WriteLine();
        string value = $"Name of the piece: {PieceName}, \nLast name, first name, second name: {AutorName},  \nGenre: {Genre}, \nYear: {Year}";
        return value;

    }

    ~Piece()
    {
        Console.WriteLine($"{PieceName}, {AutorName}, {Genre}, {Year} were remove");

    }

}
