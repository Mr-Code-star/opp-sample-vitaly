using opp_sample.procuroments.domain.model.valueObject;
using opp_sample.shared.domain.model.valueObjects;

namespace opp_sample.procuroments.domain.model.agregates;

public class PurchaseOrderItem(ProductId productId, int quantity, Money unitPrice)
{
    public ProductId ProductId {get; init;} = productId ?? throw new ArgumentNullException("ProductId cannot be null or whitespace",nameof(productId));
    public int Quantity { get; } = quantity > 0 ? quantity : throw new ArgumentOutOfRangeException("Quantity must be greater than zero.",nameof(quantity));
    public Money UnitPrice { get; } = unitPrice ?? throw new ArgumentOutOfRangeException("",nameof(unitPrice));

    public Money CalculateItemTotal => new(UnitPrice.amount * Quantity, UnitPrice.currency);
}