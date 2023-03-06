using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Emergency_Management.Models;

namespace testViewWith2model.Controllers
{
    public class StaffController : Controller
    {
        Uri baseAddress = new Uri("http://emergencyproject-001-site1.btempurl.com/api");
        HttpClient client;
        public StaffController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
            client.DefaultRequestHeaders.Add("EmergencyManagment", "B_EM_API_4.5_SECERTPASS_AH8");
        }
        // GET: Staff
        public ActionResult stafftype()
        {
            List<Staff_Type> modelList = new List<Staff_Type>();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/StaffType/Get_All_Staf_Types_of_Hospital?HOS_ID=" + 3).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<Staff_Type>>(data);
            }
            var Staff_Types = modelList;

            List<Staff> modelList2 = new List<Staff>();
            
            HttpResponseMessage response2 = client.GetAsync(client.BaseAddress + "/Staff/Get_All_Staff_Of_Hospital?HOS_ID="+3).Result;
            if (response2.IsSuccessStatusCode)
            {
                string data2 = response2.Content.ReadAsStringAsync().Result;
                modelList2 = JsonConvert.DeserializeObject<List<Staff>>(data2);
            }
            var Staffs = modelList2;

            var list = new StaffType_Staff()
            {
                Staff_Types= Staff_Types,
                Staffs= Staffs
            };

            return View(list);
            
            //return View(list.AsEnumerable());


        }

    }
}