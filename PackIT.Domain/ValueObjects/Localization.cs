using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public sealed record Localization
{
    public string City { get; }
    public string Country { get; }

    public Localization(string city, string country)
    {

        if (string.IsNullOrWhiteSpace(city))
        {

            throw new EmptyLocalizationCityNameException();
        }

        if (string.IsNullOrWhiteSpace(country))
        {

            throw new EmptyLocalizationCountryNameException();
        }

        City = city.Trim();
        Country = country.Trim();
    }

    public Localization(string localization)
    {
        if (string.IsNullOrWhiteSpace(localization))
        {
            throw new EmptyLocalizationNameException();
        }

        var parts = localization.Split(',');
        
        if (parts.Length != 2)
        {
            throw new InvalidLocalizationFormatException();
        }

        if (string.IsNullOrWhiteSpace(parts[0])){

            throw new EmptyLocalizationCityNameException();
        }

        if (string.IsNullOrWhiteSpace(parts[1])){

            throw new EmptyLocalizationCountryNameException();
        }

        City = parts[0].Trim();
        Country = parts[1].Trim();
    }

    public static implicit operator string(Localization localization) => $"{localization.City},{localization.Country}";
    public static implicit operator Localization(string localization) => new Localization(localization);
}
