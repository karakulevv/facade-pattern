namespace FacadePattern.Models;

/// <summary>
/// Subsystem Component
/// </summary>
class Lights
{
    public void Dim() => Console.WriteLine("Lights are Dimmed");
    public void Brighten() => Console.WriteLine("Lights are Brightened");
}