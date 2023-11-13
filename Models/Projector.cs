namespace FacadePattern.Models;

/// <summary>
/// Subsystem Component
/// </summary>
class Projector
{
    public void TurnOn() => Console.WriteLine("Projector is ON");
    public void TurnOff() => Console.WriteLine("Projector is OFF");
}