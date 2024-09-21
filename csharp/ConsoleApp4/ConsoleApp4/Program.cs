/*
Задание 3. Сортировка с использованием IComparable 
Создайте класс Movie, содержащий поля Title (название фильма), 
ReleaseYear (год выпуска) и Rating (рейтинг фильма). Реализуйте интерфейс IComparable, 
чтобы сортировать фильмы по году выпуска. Создайте список фильмов, 
отсортируйте его по году выпуска и выведите результат.
*/

/*
Задание 4. Реализация нескольких способов сортировки с использованием IComparer 
Используя класс Movie из задания 1,
создайте два отдельных класса, реализующих интерфейс IComparer<Movie>:
*/

using System;
using System.Collections.Generic;

public class Movie : IComparable<Movie>
{
    public string Title;
    public int ReleaseYear;
    public double Rating;

    public Movie(string title, int releaseYear, double rating)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Rating = rating;
    }

    public int CompareTo(Movie? other)
    {
        if (other == null) throw new ArgumentException("Object cannot be null");
        return this.ReleaseYear.CompareTo(other.ReleaseYear);
    }

    public override string ToString()
    {
        return $"{Title} published in {ReleaseYear} with rating {Rating}";
    }
}

public class RatingComparer : IComparer<Movie>
{
    public int Compare(Movie? x, Movie? y)
    {
        if (x == null || y == null) throw new ArgumentException("Objects cannot be null");
        return x.Rating.CompareTo(y.Rating);
    }
}

public class TitleComparer : IComparer<Movie>
{
    public int Compare(Movie? x, Movie? y)
    {
        if (x == null || y == null) throw new ArgumentException("Objects cannot be null");
        return string.Compare(x.Title, y.Title);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>
        { 
            new Movie("B", 2015, 4.5),
            new Movie("A", 2011, 3.3),
            new Movie("C", 2009, 4.1),
        };

        Console.WriteLine("Sorted by year:");
        movies.Sort();
        PrintMovies(movies);
        
        Console.WriteLine("Sorted by rating:");
        movies.Sort(new RatingComparer());
        PrintMovies(movies);

        Console.WriteLine("Sorted by title:");
        movies.Sort(new TitleComparer());
        PrintMovies(movies);
    }

    public static void PrintMovies(IEnumerable<Movie> movies)
    {
        foreach (var movie in movies)
        {
            Console.WriteLine(movie.ToString());
        }
    }
}