﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfocus.POD.BusinessLogic.BusinessObjects.Panel.NewEnquiry
{
    public class EnquiryViewModel
    {
        public System.Guid JobID { get; set; }
        public string UnitRates { get; set; }
        public Nullable<System.Guid> CompanyID { get; set; }
        public string JobNumber { get; set; }
        public Nullable<System.DateTime> JobDate { get; set; }
        public Nullable<System.DateTime> JobDateEntered { get; set; }
        public string JobEnteredBy { get; set; }
        public Nullable<System.Guid> CustomerID { get; set; }
        public string Customer { get; set; }
        public string CustomerAccount { get; set; }
        public string CustomerEntity { get; set; }
        public string JobDescription { get; set; }
        public Nullable<System.Guid> InvoiceID { get; set; }
        public Nullable<bool> IsInvoiceActive { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string Reference4 { get; set; }
        public string Reference5 { get; set; }
        public string Reference6 { get; set; }
        public string Reference7 { get; set; }
        public string Reference8 { get; set; }
        public string Reference9 { get; set; }
        public string Reference10 { get; set; }
        public string JobGroup1 { get; set; }
        public string JobGroup2 { get; set; }
        public string JobContact { get; set; }
        public string JobService { get; set; }
        public Nullable<System.Guid> ServiceCodeID { get; set; }
        public string JobKindID { get; set; }
        public bool BackToDepot { get; set; }
        public decimal Waiting { get; set; }
        public bool InvoicingOnly { get; set; }
        public Nullable<System.Guid> DepotID { get; set; }
        public string JobDepot { get; set; }
        public Nullable<System.DateTime> JobReady { get; set; }
        public Nullable<decimal> JobReadyFromCustomOffset { get; set; }
        public Nullable<System.DateTime> JobRequired { get; set; }
        public Nullable<decimal> JobRequiredCustomOffset { get; set; }
        public string JobImportTypeID { get; set; }
        public string JobStatusID { get; set; }
        public string JobStatus { get; set; }
        public string JobStatusColor { get; set; }
        public string JobPriceStatusID { get; set; }
        public string JobPriceStatus { get; set; }
        public string JobPriceStatusColor { get; set; }
        public string JobProductOwner { get; set; }
        public string JobBookingType { get; set; }
        public string JobWeightType { get; set; }
        public decimal JobQuantity { get; set; }
        public decimal JobPallets { get; set; }
        public decimal JobWeight { get; set; }
        public decimal JobCubicWeight { get; set; }
        public decimal JobCubic { get; set; }
        public decimal JobSpace { get; set; }
        public decimal JobKms { get; set; }
        public decimal JobHours { get; set; }
        public decimal JobWaiting { get; set; }
        public int JobDrops { get; set; }
        public decimal JobPrice { get; set; }
        public decimal JobCost { get; set; }
        public decimal JobExpense { get; set; }
        public Nullable<decimal> JobProfit { get; set; }
        public Nullable<decimal> JobProfitPercentage { get; set; }
        public Nullable<System.Guid> SenderID { get; set; }
        public string SenderName { get; set; }
        public string SenderLocation { get; set; }
        public string SenderAddress { get; set; }
        public string SenderSuburb { get; set; }
        public string SenderState { get; set; }
        public string SenderPostCode { get; set; }
        public string SenderPZone { get; set; }
        public string SenderAZone { get; set; }
        public string SenderCZone { get; set; }
        public string SenderDZone { get; set; }
        public string SenderNote { get; set; }
        public string SenderPhone { get; set; }
        public string SenderGroup { get; set; }
        public Nullable<System.Guid> ReceiverID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverLocation { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverSuburb { get; set; }
        public string ReceiverState { get; set; }
        public string ReceiverPostCode { get; set; }
        public string ReceiverPZone { get; set; }
        public string ReceiverAZone { get; set; }
        public string ReceiverCZone { get; set; }
        public string ReceiverDZone { get; set; }
        public string ReceiverNote { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverGroup { get; set; }
        public string Products { get; set; }
        public Nullable<int> JobLegCount { get; set; }
        public Nullable<int> FinishedJobLegCount { get; set; }
        public string InvoiceStatus { get; set; }
        public string InvoiceStatusID { get; set; }
        public string InvoiceStatusColor { get; set; }
        public string InvoiceNo { get; set; }
        public string ActivePODs { get; set; }
        public Nullable<bool> HasHandwrittenPOD { get; set; }
        public Nullable<bool> AppPOD { get; set; }
        public Nullable<bool> IsPODRequired { get; set; }
        public Nullable<bool> isPODRequiredBeforeInvoicing { get; set; }
        public Nullable<bool> IsCustomerPODRequired { get; set; }
        public string SpecialInstructions { get; set; }
        public string TrackingCode { get; set; }
        public string JobLegIDs { get; set; }
        public string ShippingUnits { get; set; }
        public Nullable<int> CreatedKind { get; set; }
        public Nullable<bool> HasJobPOD { get; set; }
        public string AllJobPODs { get; set; }
        public Nullable<bool> AutoPriceComplete { get; set; }
        public Nullable<long> JobNumberNumeral { get; set; }
        public string PricingType { get; set; }
        public string JobNotes { get; set; }
        public string PricingNotes { get; set; }
        public dynamic ProductName { get; set; }
        public string ProductsDetail { get; set; }
        public dynamic ProductDescription { get; set; }
        public dynamic JobLegCustomActivities { get; set; }
        public Nullable<int> PODPhotoCount { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string CustomerInvoicingFrequency { get; set; }
        public dynamic JobLegBottleTrack { get; set; }
        public string FirstLegManifestNumber { get; set; }

    }
}
