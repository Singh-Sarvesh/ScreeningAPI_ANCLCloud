using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebooking_screeningAPI.Models
{
    public class ControlData
    {
        public int ID { get; set; }
        public string Value { get; set; }
        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public int PEID { get; set; }
        public string PECode { get; set; }
        public string AdSizeValue { get; set; }
    }
}