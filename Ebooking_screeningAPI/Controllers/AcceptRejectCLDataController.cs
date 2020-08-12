using System;
using System;
using System.Collections.Generic;
using Ebooking_screeningAPI.Models;
using System.Web.Http;
using System.Data;
using Ebooking_screeningDAL;

namespace Ebooking_screeningAPI.Controllers
{
    public class AcceptRejectCLDataController : ApiController
    {

        HomeDAL objHomeDAL = new HomeDAL();
        [HttpPost]
        public IEnumerable<ControlData> Post(BookingDetail objbookingDetail)
        {
            List<ControlData> objListcontroldata = new List<ControlData>();
            try
            {
                DataTable objdt = objHomeDAL.AcceptRejectCLData(objbookingDetail.AcceptReject, objbookingDetail.ReasonID, objbookingDetail.StrReason, objbookingDetail.ROID, objbookingDetail.PEID, objbookingDetail.IsClassified, objbookingDetail.UserId).Tables[0];
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
