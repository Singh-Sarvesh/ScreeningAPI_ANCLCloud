using DBInterface;
using System;
using System.Data;


namespace Ebooking_screeningDAL
{
    public class HomeDAL
    {

        public DataSet GeteBookingLoginData(string xmlData)
        {
            using (var db = new DBManager())
            {
                db.Open();
                DataSet ds = db.ExecuteDataSet(CommandType.Text, xmlData);
                return ds;
            }
        }

        public DataSet GeteBookingControlData(string xmlData)
        {
            DataSet ds = new DataSet();
            Utility.ReportXMLLog("SP_Name::EBK_SP_OrderScreenFilters:", xmlData);
            try
            {
                using (var db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@XMLBody", xmlData);
                    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "EBK_SP_OrderScreenFilters");
                    return ds;
                }
            }
            catch (Exception ex)
            {
                Utility.ReportLogError("SP_Name::EBK_SP_OrderScreenFilters:", ex, xmlData);
            }
            return ds;
        }

        public DataSet AcceptRejectCLData(int orderstatus,int reasonid,string remarks, Int64 roid,int peid, int isclassified, int userid)
        {
            DataSet ds = new DataSet();
            if (remarks == null)
            {
                remarks = "";
            }
            try
            {
                using (var db = new DBManager())
            {
                db.Open();
                db.CreateParameters(7);
                db.AddParameters(0, "@OrderStatus", orderstatus);
                db.AddParameters(1, "@ReasonID", reasonid);
                db.AddParameters(2, "@Remarks", remarks);
                db.AddParameters(3, "@ROID", roid);
                db.AddParameters(4, "@PEID", peid);
                db.AddParameters(5, "@isClassified", isclassified);
                db.AddParameters(6, "@UserID", userid);
                ds = db.ExecuteDataSet(CommandType.StoredProcedure, "EBK_SP_ApprovedRejected");
            }
            }
            catch (Exception ex)
            {
                Utility.ReportLogError("SP_Name::EBK_SP_OrderScreenFilters:", ex ,"");
            }
            return ds;
        }

    }
}
