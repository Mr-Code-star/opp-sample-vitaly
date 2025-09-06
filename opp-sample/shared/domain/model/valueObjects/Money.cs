namespace opp_sample.shared.domain.model.valueObjects;

/// <summary>
/// Value Object representing Money with an amount and a Currency
/// </summary>
public record Money
{
    public decimal amount { get; init; }
    public string currency { get; init; }

    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
        {
            throw new ArgumentException("Currency must be a valid 3-letter ISO code", nameof(currency));
        }

        this.amount = amount;
        this.currency = currency.ToUpper();
    }
}