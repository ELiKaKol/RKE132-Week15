List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

    if (tempArray.Length == 3)
    {
        string title = tempArray[0];
        string rating = tempArray[1];
        string year = tempArray[2];
        Movie newMovie = new Movie(title, rating, year);
        myMovies.Add(newMovie);
    }
    else
    {
        Console.WriteLine($"Warning: Skipping invalid line: {line}");
    }
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year} with a rating of {movie.Rating}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\flami\OneDrive\Desktop\prog\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string rating;
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Rating
    {
        get { return rating; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _rating, string _year)
    {
        title = _title;
        rating = _rating;
        year = _year;
    }
}
