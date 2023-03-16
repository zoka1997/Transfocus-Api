namespace TransfocusAPI.HelperClasses
{
    public class JobPricingList
    {
        public Guid ID { get; set; }
        public Guid PricingID { get; set; }
        public string PricingItem { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string ChargeUnit { get; set; }
        public decimal UnitRate { get; set; }
        public bool ApplyFuelLevy { get; set; }
        public decimal Amount { get; set; }
        public string PricingCodeXero { get; set; }
        public string XeroAccountCode { get; set; }
    }
}
