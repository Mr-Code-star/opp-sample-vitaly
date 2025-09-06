namespace opp_sample.SCM.domain.model.valueobject;

public record sumplierId
{
    public string identifier { get; init; }
    
    /// <summary>
    /// Creates a new SuplierId Instace 
    /// </summary>
    
    public sumplierId(string Identifier)
    {
        if(string.IsNullOrWhiteSpace(Identifier))
            throw new ArgumentNullException("identifier cannot be null or whitespace.", nameof(identifier));
        identifier = Identifier;
    }
};