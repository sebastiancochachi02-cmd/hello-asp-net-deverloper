namespace Acne.Hello.Plataform.Generic.Interfaces.REST.Resources;
/// <summary>
/// A record represeting the response for greating requeset
/// </summary>
/// <param name="Id">The unique identifier for the greating may be null</param>
/// <param name="FullName">the full name of the developer may be null</param>
/// <param name="Message">the greating massage</param>
public record GreatDeveloperResponse(Guid? Id, string? FullName, string? Message)
{
public GreatDeveloperResponse(string message) : this(null, null, message) { }
}