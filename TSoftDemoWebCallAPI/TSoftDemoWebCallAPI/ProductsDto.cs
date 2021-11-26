using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSoftDemoWebCallAPI
{
    public class ProductsDto
    {
        public bool Success { get; set; }
        public Data[] Data { get; set; }
        public Messages[] Message { get; set; }
        public Summary Summary { get; set; }
    }

    public class Data
    {
        public long ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public long DefaultCategoryId { get; set; }
        public string DefaultCategoryName { get; set; }
        public string DefaultCategoryPath { get; set; }
        public string SupplierProductCode { get; set; }
        public long Barcode { get; set; }
        public long Stock { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool HasSubProducts { get; set; }
        public long Vat { get; set; }
        public long CurrencyId { get; set; }
        public long BuyingPrice { get; set; }
        public long SellingPrice { get; set; }
        public long DiscountedPrice { get; set; }
        public long SellingPriceVatIncludedNoDiscount { get; set; }
        public long SellingPriceVatIncluded { get; set; }
        public string SeoLink { get; set; }
        public string StockUnit { get; set; }
        public long StockUnitId { get; set; }
        public string SearchKeywords { get; set; }
        public bool DisplayOnHomepage { get; set; }
        public bool IsNewProduct { get; set; }
        public bool OnSale { get; set; }
        public bool IsDisplayProduct { get; set; }
        public bool VendorDisplayOnly { get; set; }
        public bool DisplayWithVat { get; set; }
        public string Brand { get; set; }
        public long BrandId { get; set; }
        public string BrandLink { get; set; }
        public string Model { get; set; }
        public long ModelId { get; set; }
        public long SupplierId { get; set; }
        public string CustomerGroupDisplay { get; set; }
        public string ImageUrl { get; set; }
        public bool Magnifier { get; set; }
        public long MemberMinOrder { get; set; }
        public long MemberMaxOrder { get; set; }
        public long VendorMinOrder { get; set; }
        public long VendorMaxOrder { get; set; }
        public string ShortDescription { get; set; }
        public DateTimeOffset SavingDate { get; set; }
        public long CreateDateTimeStamp { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public long FilterGroupId { get; set; }
        public long ListNo { get; set; }
        public long OwnerId { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string StockUpdateDate { get; set; }
        public string PriceUpdateDate { get; set; }
        public string StockUpdatePlatform { get; set; }
        public string PriceUpdatePlatform { get; set; }
        public long Gender { get; set; }
        public long OpportunityProduct { get; set; }
        public long OpportunityStart { get; set; }
        public long OpportunityFinish { get; set; }
        public string AgeGroup { get; set; }
        public long CommentRate { get; set; }
        public DisablePaymentType[] DisablePaymentTypes { get; set; }
        public object[] DisableCargoCompany { get; set; }
        public long StatViews { get; set; }
        public long StatRecommendations { get; set; }
        public long HomepageSort { get; set; }
        public long MostSoldSort { get; set; }
        public long NewestSort { get; set; }
        public long Point { get; set; }
        public long EftRate { get; set; }
        public long Numeric1 { get; set; }
        public bool HasImages { get; set; }
        public long Label1 { get; set; }
        public long Label2 { get; set; }
        public long Label3 { get; set; }
        public long Label4 { get; set; }
        public long Label5 { get; set; }
        public long Label6 { get; set; }
        public long Label7 { get; set; }
        public long Label8 { get; set; }
        public long Label9 { get; set; }
        public long Label10 { get; set; }
        public string Additional1 { get; set; }
        public string Additional2 { get; set; }
        public string Additional3 { get; set; }
        public string Currency { get; set; }
        public string Supplier { get; set; }
        public string DefaultCategoryCode { get; set; }
        public string ImageUrlCdn { get; set; }
    }

    public class DisablePaymentType
    {
        public long Id { get; set; }
        public bool Status { get; set; }
    }

    public class Messages
    {
        public long Type { get; set; }
        public string Code { get; set; }
        public long Index { get; set; }
        public string Id { get; set; }
        public string Subid { get; set; }
        public string[] Text { get; set; }
        public object[] ErrorField { get; set; }
    }

    public class Summary
    {
        public long TotalRecordCount { get; set; }
        public string PrimaryKey { get; set; }
    }
}