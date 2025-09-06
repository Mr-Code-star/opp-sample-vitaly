namespace opp_sample.procuroments.domain.model.valueObject;

public record ProductId
{
    public Guid Id { get; init; }

    public ProductId(Guid id)
    {
        if(id == Guid.Empty)
            throw new ArgumentException("id cannot be empty", nameof(id));
        Id = id;
    }
    public override string ToString() => Id.ToString();
    public static ProductId New() => new(Guid.NewGuid());
};