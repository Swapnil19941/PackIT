using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyLocalizationCityNameException : PackITException
{
    public EmptyLocalizationCityNameException() : base("Localization city name cannot be empty.")
    {
    }
}
