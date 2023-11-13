namespace FacadePattern.Models;

/// <summary>
/// Subsystem Component
/// </summary>
class SoundSystem
{
    public void TurnOn() => Console.WriteLine("Sound System is ON");
    public void TurnOff() => Console.WriteLine("Sound System is OFF");
}