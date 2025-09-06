using opp_sample.procuroments.domain.model.valueObject;
using opp_sample.SCM.domain.model.valueobject;
using opp_sample.shared.domain.model.valueObjects;

namespace opp_sample.procuroments.domain.model.agregates;

public class PurchaseOrden(string orderNumber, sumplierId supplierId, DateTime orderDate, string currency)
{
    private readonly List<PurchaseOrderItem> items = new();
    
    public string OrderNumber { get; } = orderNumber ?? throw new ArgumentNullException(nameof(orderNumber));
    
    public sumplierId SumplierId { get; } = supplierId ?? throw new ArgumentNullException(nameof(supplierId));
    public DateTime OrderDate { get; } = orderDate;
    
    public string Currency { get;} = String.IsNullOrWhiteSpace(currency) || currency.Length !=3
        ? throw new ArgumentException("Currency must be 3 or more characters.", nameof(currency))
        : currency;

    public IReadOnlyList<PurchaseOrderItem> Items => items.AsReadOnly();

    public void AddItem(ProductId productId, int quantity, decimal unitPriceAmount)
    {
        ArgumentNullException.ThrowIfNull(productId);

        if (quantity <= 0) throw new ArgumentException("quatity must be great that zero");
        if(unitPriceAmount <= 0)  throw new ArgumentException("unitPriceAmount must be great than zero");
        
        var unitPrice = new Money(unitPriceAmount, Currency);

        var item = new PurchaseOrderItem(productId, quantity, unitPrice);
        items.Add(item);
    }
    
    public Money CalculateTotal()
    {
        if (!items.Any())
            return new Money(0, Currency);

        var totalAmount = items.Sum(i => i.CalculateItemTotal.amount);
        return new Money(totalAmount, Currency);
    }
}