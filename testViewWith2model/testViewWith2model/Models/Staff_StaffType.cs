using Emergency_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emergency_Management.Models
{
    public class Staff_StaffType
    {
        public List<Staff> Staffs { set; get; }
        public List<Staff_Type> Staff_Types { set; get; }

    }
}