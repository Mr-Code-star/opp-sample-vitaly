using opp_sample.shared.domain.model.valueObjects;

namespace opp_sample.SCM.domain.model.agregates;

public class Suplier(string identifier, string name, Address address)
{
    public string Identifier { get; set; } = identifier ?? throw new ArgumentNullException(nameof(identifier));
    public string Name { get; set; } = name ?? throw new ArgumentNullException(nameof(name));
    public Address Address { get; set; } = address ?? throw new ArgumentNullException(nameof(address));
}