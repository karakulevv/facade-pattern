namespace FacadePattern.Models;

/// <summary>
/// Facade
/// </summary>
class HomeTheaterFacade
{
    private DVDPlayer dvdPlayer;
    private Projector projector;
    private Lights lights;
    private SoundSystem soundSystem;

    public HomeTheaterFacade()
    {
        dvdPlayer = new DVDPlayer();
        projector = new Projector();
        lights = new Lights();
        soundSystem = new SoundSystem();
    }

    public void WatchMovie()
    {
        Console.WriteLine("Get ready to watch a movie!");
        lights.Dim();
        projector.TurnOn();
        soundSystem.TurnOn();
        dvdPlayer.TurnOn();
    }

    public void EndMovie()
    {
        Console.WriteLine("Movie is over. Cleaning up...");
        dvdPlayer.TurnOff();
        soundSystem.TurnOff();
        projector.TurnOff();
        lights.Brighten();
    }
}