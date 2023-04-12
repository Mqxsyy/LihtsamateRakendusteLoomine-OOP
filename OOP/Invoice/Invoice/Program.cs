namespace Invoice
{
    public class Program
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int Discount { get; set; }
        }

        public class Invoice
        {
            public int Id { get; set; }
            public string InvoiceNumber { get; set; }
            public DateTime InvoiceDate { get; set; }
            public DateTime DueDate { get; set; }
            public decimal Discount { get; set; }
            public decimal Shipping { get; set; }

            public Customer Customer { get; set; }
            public IList<InvoiceLine> Lines { get; set; }
            
            public decimal SubTotal { get; set; }
            public decimal GrandTotal { get; set; }

        }
          
        public class InvoiceLine
        {
            public int Id { get; set; }
            public string Item { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Quantity { get; set; }
            public int VatPercent { get; set; }
            public int Discount { get; set; }

            public decimal Total { get; set; }
        }
    }
}
