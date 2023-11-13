using FacadePattern.Models;

namespace FacadePattern;

class Program
{
    public static void Main(string[] args)
    {
        HomeTheaterFacade homeTheater = new HomeTheaterFacade();

        // Watching a movie
        homeTheater.WatchMovie();

        Console.WriteLine("\nMovie experience is complete!\n");

        // Ending the movie
        homeTheater.EndMovie();

        //Waiting for user input
        Console.ReadKey();
    }
}