using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyLocalizationNameException : PackITException
{
    public EmptyLocalizationNameException() : base("Localization cannot be empty.")
    {
    }
}
