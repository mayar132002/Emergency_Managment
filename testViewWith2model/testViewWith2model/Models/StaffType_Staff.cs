using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emergency_Management.Models
{
    public class StaffType_Staff
    {
        public List<Staff> Staffs { set; get; }
        public List<Staff_Type> Staff_Types { set; get; }
       
    }
}