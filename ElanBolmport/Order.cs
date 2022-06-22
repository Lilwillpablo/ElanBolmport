using Newtonsoft.Json;

namespace JsonProperties
{
    internal class Order
    {
        public string orderId { get; set; }
        [JsonProperty("id")]
        public string boNumber { get; set; }
        [JsonProperty("shiptoCustomerNameId")]
        public string shipToID { get; set; }
        [JsonProperty("shipto_customer_name_assoc_fullName")]
        public string shipToCustomerNameAssocFullName { get; set; }
        [JsonProperty("order_header_assoc_holdUntilDate")]
        public string bocDate { get; set; }
        [JsonProperty("productId")]
        public string isbn { get; set; }
        [JsonProperty("book_products_assoc_title")]
        public string bookProductsAssocTitle { get; set; }
        public string[] statusWarehouseIds { get; set; }
        public string[] statusCodes { get; set; }
        [JsonProperty("statusQuantities")]
        public string[] Qty { get; set; }
        [JsonProperty("statusAmounts")]
        public string[] Price { get; set; }
        [JsonProperty("order_header_assoc_orderDate")]
        public string OrdDate { get; set; }
        public string order_header_assoc_entryDate { get; set; }
        public string book_products_assoc_majorDisc { get; set; }
        public string book_products_assoc_minorDisc { get; set; }
        public string order_header_assoc_operator { get; set; }
        [JsonProperty("discountPct")]
        public string Discount { get; set; }
        [JsonProperty("order_header_assoc_book_customer_assoc_defaultOrderBilltoId")]
        public string BillToID { get; set; }
        [JsonProperty("book_products_assoc_book_prices_assoc_product_assoc_listPrice")]
        public string[] listPrice { get; set; }

    }
}

