using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Product
    {
        public Product()
        {
            CostProductCards = new HashSet<CostProductCard>();
            CustomerProducts = new HashSet<CustomerProduct>();
            JobLegProducts = new HashSet<JobLegProduct>();
            JobProducts = new HashSet<JobProduct>();
            PriceProductCards = new HashSet<PriceProductCard>();
            ProductLocations = new HashSet<ProductLocation>();
            ServiceCodeProducts = new HashSet<ServiceCodeProduct>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Cubic { get; set; }
        public bool Active { get; set; }
        public string? Reference { get; set; }
        public decimal QuantityPerUnit { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Depth { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? CustomerId { get; set; }
        public bool IsDefault { get; set; }
        public bool ExportedToFoxPro { get; set; }
        public string ShippingUnit { get; set; } = null!;
        public bool IsShippingUnit { get; set; }
        public decimal? Space { get; set; }
        public Guid? PricingUnitId { get; set; }
        public bool IsPricingUnit { get; set; }
        public decimal? Otweight { get; set; }
        public decimal? Delweight { get; set; }
        public string? GroupId { get; set; }
        public string? PricingUnit { get; set; }
        public int CubicWeightConvRate { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MaxCubic { get; set; }
        public decimal? MaxWidth { get; set; }
        public decimal? MaxHeight { get; set; }
        public decimal? MaxDepth { get; set; }
        public int? MaxQuantity { get; set; }
        public Guid? RecomendedProduct { get; set; }
        public bool? AllowEntryIfValidationFails { get; set; }
        public decimal? MaxSpace { get; set; }
        public bool DisableSubtotalPricing { get; set; }
        public string? Account { get; set; }
        public string? ProductCode { get; set; }
        public bool DisallowEntryOnBooking { get; set; }
        public Guid? Group1Id { get; set; }
        public Guid? Group2Id { get; set; }
        public Guid? PricingId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual GenericGroup? Group1 { get; set; }
        public virtual GenericGroup? Group2 { get; set; }
        public virtual Pricing? Pricing { get; set; }
        public virtual ICollection<CostProductCard> CostProductCards { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<JobLegProduct> JobLegProducts { get; set; }
        public virtual ICollection<JobProduct> JobProducts { get; set; }
        public virtual ICollection<PriceProductCard> PriceProductCards { get; set; }
        public virtual ICollection<ProductLocation> ProductLocations { get; set; }
        public virtual ICollection<ServiceCodeProduct> ServiceCodeProducts { get; set; }
    }
}
