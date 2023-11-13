namespace FacadePattern.Models;

/// <summary>
/// Subsystem Component
/// </summary>
class DVDPlayer
{
    public void TurnOn() => Console.WriteLine("DVD Player is ON");
    public void TurnOff() => Console.WriteLine("DVD Player is OFF");
}