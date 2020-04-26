using System.Collections.Generic;
using TusLibros.UnitTests.MerchantFakes;

namespace TusLibros.UnitTests
{
    public static class Helpers
    {
        public static readonly object VALID_ITEM = new object();
        public static readonly object ANOTHER_VALID_ITEM = new object();
        public static readonly object INVALID_ITEM = new object();
        public const decimal VALID_PRICE = 10;
        public const decimal ANOTHER_VALID_PRICE = 3;
        public const string VALID_CREDIT_CARD = "1234567890123456";
        public const string INVALID_CREDIT_CARD_NUMBER = "999";
        public const string ANOTHER_INVALID_CREDIT_CARD_NUMBER = "1234-5678-123411";
        public const string SUCCESSFUL_TRANSACTION_ID = "Todo bien";

        public static List<object> GetCatalogWithValidItem() => new List<object>() { VALID_ITEM };
        public static System.Collections.Generic.List<object> GetCatalogWithTwoValidItems() => new List<object>() { VALID_ITEM, ANOTHER_VALID_ITEM };
        public static Cart GetCartWithACatalogWithValidItem() => new Cart(GetCatalogWithValidItem());
        public static Cart GetCartWithACatalogWithTwoValidItems() => new Cart(GetCatalogWithTwoValidItems());
        public static Cart GetCartWithEmptyCatalog() => new Cart(new List<object>());
        public static Cart GetCartWithOneItem()
        {
            var cart = GetCartWithACatalogWithValidItem();
            cart.Add(VALID_ITEM, 1);
            return cart;
        }
        public static Cashier GetCashierWithPricelistWithOneItemAndDummyMerchant()
        {
            return new Cashier(GetPricelistWithOneValidItem(VALID_PRICE), new DummyMerchant());
        }
        public static Dictionary<object, decimal> GetPricelistWithOneValidItem(decimal price)
        {
            return new Dictionary<object, decimal>
            {
                { VALID_ITEM, price }
            };
        }
        public static Dictionary<object, decimal> GetPricelistWithTwoValidItems()
        {
            return new Dictionary<object, decimal>
            {
                { VALID_ITEM, VALID_PRICE },
                { ANOTHER_VALID_ITEM, ANOTHER_VALID_PRICE }
            };
        }
        public static Dictionary<object, decimal> GetEmptyPricelist()
        {
            return new Dictionary<object, decimal>();
        }
    }
}