using System;
using System.Collections.Generic;
using Ebooking_screeningAPI.Models;
using System.Web.Http;
using System.Data;
using Ebooking_screeningDAL;

namespace Ebooking_screeningAPI.Controllers
{
    public class AcceptRejectDataController : ApiController
    {

        HomeDAL objHomeDAL = new HomeDAL();
        [HttpPost]
        public IEnumerable<ControlData> Post(BookingDetail objbookingDetail)
        {
            List<ControlData> objListcontroldata = new List<ControlData>();
            try
            {
                string strXml = "<ebooking><actionname>" + objbookingDetail.Parametername + "</actionname>"
                              + "<roidlist>" + objbookingDetail.RoidList + "</roidlist>"
                              + "<orderstatus>" + objbookingDetail.AcceptReject + "</orderstatus>"
                              + "<reasonid>" + objbookingDetail.ReasonID + "</reasonid>"
                              + "<remarks>" + objbookingDetail.StrReason + "</remarks>"
                              + "<screentype>" + objbookingDetail.ScreenType + "</screentype>"
                              + "<userid>" + objbookingDetail.UserId + "</userid></ebooking>";
                DataTable objdt = objHomeDAL.GeteBookingControlData(strXml).Tables[0];
                ControlData objcontroldata;
                foreach (DataRow dr in objdt.Rows)
                {
                    objcontroldata = new ControlData();
                    objcontroldata.ID = Convert.ToInt32(dr[0]);
                    objcontroldata.Value = Convert.ToString(dr[1]);
                    objListcontroldata.Add(objcontroldata);
                }
            }
            catch (Exception ex)
            {
            }
            return objListcontroldata;
        }

    }
}
