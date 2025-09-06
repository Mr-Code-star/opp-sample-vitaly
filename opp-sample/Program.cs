// See https://aka.ms/new-console-template for more information
using opp_sample.procuroments.domain.model.agregates;
using opp_sample.procuroments.domain.model.valueObject;

using opp_sample.SCM.domain.model.valueobject;
using opp_sample.SCM.domain.model.agregates;
using opp_sample.shared.domain.model.valueObjects;

var supplierAddres = new Address("Alameda", "123", "Chorrilos", "Lima", "1231", "Peru");
var suplier = new Suplier("SUP001", "UPC", supplierAddres);

var purchaseOrder = new PurchaseOrden("", new sumplierId(suplier.Identifier), DateTime.Now, "USD");

purchaseOrder.AddItem(ProductId.New(), 15, 2.5m);
purchaseOrder.AddItem(ProductId.New(), 20, 7.5m);

Console.WriteLine($"Purchase Order {purchaseOrder.OrderNumber} created for supplier id {suplier.Identifier} in {purchaseOrder.Currency}");

foreach (var  item in purchaseOrder.Items)
{
    Console.WriteLine($"Item Subtotal: {item.CalculateItemTotal.amount } {item.CalculateItemTotal.currency}");
}

Console.WriteLine($"Total: {purchaseOrder.CalculateTotal().amount} {purchaseOrder.CalculateTotal().currency}");
