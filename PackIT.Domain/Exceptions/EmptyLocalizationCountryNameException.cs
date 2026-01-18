using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyLocalizationCountryNameException : PackITException
{
    public EmptyLocalizationCountryNameException() : base("Localization Coutry name cannot be empty.")
    {

    }
}
