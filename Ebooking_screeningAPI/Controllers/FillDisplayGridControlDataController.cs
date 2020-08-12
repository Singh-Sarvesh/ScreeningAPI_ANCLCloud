using System;
using System.Collections.Generic;
using Ebooking_screeningAPI.Models;
using System.Web.Http;
using System.Data;
using Ebooking_screeningDAL;

namespace Ebooking_screeningAPI.Controllers
{
    public class FillDisplayGridControlDataController : ApiController
    {

        HomeDAL objHomeDAL = new HomeDAL();
        [HttpPost]
        public IEnumerable<GridData> Post(BookingDetail objbookingDetail)
        {
            List<GridData> objListgriddata = new List<GridData>();
            try
            {
                string strXml = "<ebooking><actionname>" + objbookingDetail.Parametername + "</actionname><isclassified>" + objbookingDetail.IsClassified + "</isclassified>";
                strXml += "<roid>" + objbookingDetail.ROID + "</roid>"
                       + "<languageid>" + objbookingDetail.LanguageID + "</languageid>"
                       + "<peid>" + objbookingDetail.PEID + "</peid>"
                       + "<bookingid>" + objbookingDetail.BookingID + "</bookingid>"
                       + "<adtypeid>" + objbookingDetail.AdtypeId + "</adtypeid>"
                       + "<statusid>" + objbookingDetail.StatusID + "</statusid>"
                       + "<fromdate>" + objbookingDetail.DateFrom + "</fromdate>"
                       + "<todate>" + objbookingDetail.DateTo + "</todate>"
                       + "<dateflag>" + objbookingDetail.DateFlag + "</dateflag>"
                       + "<packageidlist>" + objbookingDetail.PackageID + "</packageidlist>"
                       + "<loguserid>" + objbookingDetail.UserId + "</loguserid>"
                       + "<agencyid>" + objbookingDetail.AgencyID + "</agencyid>"
                       + "<casualclientname>" + objbookingDetail.CasualClientName + "</casualclientname>"
                       + "<canvassorid>" + objbookingDetail.CanvassorID + "</canvassorid>"
                       + "<ccofficerid>" + objbookingDetail.CcofficerID + "</ccofficerid>"
                       + "<flag>" + objbookingDetail.Flag + "</flag></ebooking>";

                DataTable objdt = objHomeDAL.GeteBookingControlData(strXml).Tables[0];
                GridData objgriddata;
                foreach (DataRow dr in objdt.Rows)
                {
                    objgriddata = new GridData();
                   // objgriddata.SNO = Convert.ToInt32(dr["SNO"]);
                    objgriddata.IsClassified = Convert.ToInt32(dr["IsClassified"]);
                    objgriddata.Roid = Convert.ToInt64(dr["ROID"]);
                    //objgriddata.InsNum = Convert.ToInt32(dr["InsNum"]);
                    //objgriddata.PEID = Convert.ToInt32(dr["PEID"]);
                    objgriddata.SourceROID = Convert.ToInt64(dr["SourceROID"]);
                    objgriddata.BookingDate = Convert.ToDateTime(dr["BookingDate"]).ToString("dd/MM/yyyy HH:mm:ss");
                    //objgriddata.BookingNumber = Convert.ToInt64(dr["BookingNumber"]);
                    objgriddata.ScheduledDate = Convert.ToDateTime(dr["ScheduledDate"]).ToString("dd/MM/yyyy");
                    objgriddata.AgencyID = Convert.ToInt32(dr["AgencyID"]);
                    objgriddata.ClientID = Convert.ToInt32(dr["ClientID"]);
                    objgriddata.CanvassorID = Convert.ToInt32(dr["CanvassorID"]);
                    objgriddata.RevenueCentreID = Convert.ToInt32(dr["RevenueCentreID"]);
                    objgriddata.BookingCentreID = Convert.ToInt32(dr["BookingCentreID"]);
                    objgriddata.BookingExecID = Convert.ToInt32(dr["BookingExecID"]);
                    objgriddata.RONumber = Convert.ToString(dr["RONumber"]);
                    objgriddata.Rate = Convert.ToString(dr["Rate"]);
                    objgriddata.CurrentAdVal = Convert.ToString(dr["CurrentAdVal"]);
                    objgriddata.PackageID = Convert.ToInt32(dr["PackageID"]);
                    objgriddata.PremiaID = Convert.ToInt32(dr["PremiaID"]);
                    objgriddata.AdtypeID = Convert.ToInt32(dr["AdtypeID"]);
                    objgriddata.Color = Convert.ToInt32(dr["Color"]);
                    objgriddata.Adarea = Convert.ToString(dr["Adarea"]);
                    objgriddata.AdSize = Convert.ToString(dr["AdSize"]);
                    objgriddata.No_of_Insertions = Convert.ToInt32(dr["No_of_Insertions"]);
                    objgriddata.AgencyName = Convert.ToString(dr["Agency Name"]);
                    objgriddata.ClientName = Convert.ToString(dr["Client Name"]);
                    objgriddata.BookingExecName = Convert.ToString(dr["BookingExecName"]);
                    objgriddata.PackageName = Convert.ToString(dr["PackageName"]);
                    objgriddata.PremiaName = Convert.ToString(dr["PremiaName"]);
                    objgriddata.BookingCentreName = Convert.ToString(dr["BookingCentreName"]);
                    objgriddata.AdtypeName = Convert.ToString(dr["AdtypeName"]);
                    //objgriddata.Class1 = Convert.ToString(dr["Class1"]);
                    //objgriddata.Class2 = Convert.ToString(dr["Class2"]);
                    objgriddata.ColorName = Convert.ToString(dr["ColorName"]);
                   // objgriddata.CanvassorName = Convert.ToString(dr["CanvassorName"]);
                    objgriddata.ApprovalDate = Convert.ToString(dr["ApprovalDate"]);
                    objgriddata.CloudOrderStatus = Convert.ToString(dr["CloudOrderStatus"]);
                    objgriddata.OrderStatusName = Convert.ToString(dr["OrderStatusName"]);
                    //objgriddata.Language = Convert.ToString(dr["Language"]);
                    //objgriddata.Edition = Convert.ToString(dr["Edition"]);
                    //objgriddata.OtherPE = Convert.ToString(dr["OtherPE"]);
                    objgriddata.RejectedReasonID = Convert.ToString(dr["RejectedReasonID"]);
                    objgriddata.ReasonName = Convert.ToString(dr["ReasonName"]);
                    objgriddata.RejectedNote = Convert.ToString(dr["RejectedNote"]);
                    //objgriddata.AdText = Convert.ToString(dr["AdText"]);
                    objgriddata.InsDates = Convert.ToString(dr["InsDates"]);
                    objListgriddata.Add(objgriddata);
                }

            }
            catch (Exception ex)
            {
            }
            return objListgriddata;
        }

    }
}
