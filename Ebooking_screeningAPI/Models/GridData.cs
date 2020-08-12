using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebooking_screeningAPI.Models
{
    public class GridData
    {
        public int SNO { get; set; }
        public int IsClassified { get; set; }
        public Int64 Roid { get; set; }
        public Int64 BookingID { get; set; }
        public int InsNum { get; set; }
        public int PEID { get; set; }
        public Int64 SourceROID { get; set; }
        public string BookingDate { get; set; }
        public Int64 BookingNumber { get; set; }
        public string ScheduledDate { get; set; }
        public int AgencyID { get; set; }
        public int ClientID { get; set; }
        public int CanvassorID { get; set; }
        public int RevenueCentreID { get; set; }
        public int BookingCentreID { get; set; }
        public int BookingExecID { get; set; }
        public string RONumber { get; set; }
        public string SchedulingInstructions { get; set; }
        public int PackageID { get; set; }
        public int PremiaID { get; set; }
        public int AdtypeID { get; set; }
        public int Color { get; set; }
        public string Adarea { get; set; }
        public string AdSize { get; set; }
        public int No_of_Insertions { get; set; }
        public string AgencyName { get; set; }
        public string ClientName { get; set; }
        public string CasualClientName { get; set; }
        public string PackageName { get; set; }
        public string PremiaName { get; set; }
        public string BookingCentreName { get; set; }
        public string AdtypeName { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public string ColorName { get; set; }
        public string BookingExecName { get; set; }
        public string Rate { get; set; }
        public string CurrentAdVal { get; set; }
        public string CanvassorName { get; set; }
        public string Ag_Exec_No { get; set; }
        public string ApprovalDate { get; set; }
        public string CloudOrderStatus { get; set; }
        public string OrderStatusName { get; set; }
        public string RejectedNote { get; set; }
        public string Language { get; set; }
        public string Edition { get; set; }
        public string OtherPE { get; set; }
        public string RejectedReasonID { get; set; }
        public string ReasonName { get; set; }
        public string AdText { get; set; }
        public string AdTexts { get; set; }
        public string InsDates { get; set; }

    }
}