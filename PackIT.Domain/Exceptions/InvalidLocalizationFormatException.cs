using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class InvalidLocalizationFormatException : PackITException
{
    public InvalidLocalizationFormatException() : base("Invalid Localization format.")
    {

    }
}
