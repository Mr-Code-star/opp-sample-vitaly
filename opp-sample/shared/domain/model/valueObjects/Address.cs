namespace opp_sample.shared.domain.model.valueObjects;
/// <summary>
/// Value Object represting Address
/// </summary>
public record Address
{
    public string Street { get; init; }
    public string Number { get; init; }
    public string City { get; init; }
    public string? StateorRegion { get; init; }
    public string PostalCode { get; init; }
    public string Country { get; init; }

    /// <summary>
    /// Creates a new addres instace
    ///</summary>
    
    public Address(string street, string number, string city, string stateorRegion, string postalCode, string country)
    {
        if (string.IsNullOrWhiteSpace(street))
            throw new ArgumentException("Street cannot be null or whitespace", nameof(street));
        if (string.IsNullOrWhiteSpace(number))
            throw new ArgumentException("Number cannot be null or whitespace", nameof(number));
        if (string.IsNullOrWhiteSpace(city))
            throw new ArgumentException("City cannot be null", nameof(city));
        if (string.IsNullOrWhiteSpace(stateorRegion))
            throw new ArgumentException("StateorRegion cannot be null", nameof(stateorRegion));
        if (string.IsNullOrWhiteSpace(postalCode))
            throw new ArgumentException("PostalCode cannot be null", nameof(postalCode));
        if (string.IsNullOrWhiteSpace(country))
            throw new ArgumentException("Country cannot be null", nameof(country));
        
        Street = street;
        Number = number;
        City = city;
        StateorRegion = stateorRegion;
        PostalCode = postalCode;
        Country = country;
    }
    
    public override string ToString() => $"{Street}, {Number}, {City}, {StateorRegion}, {PostalCode}, {Country}";
};