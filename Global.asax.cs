using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication1.Models;
using System.Web.Caching;


namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
           // FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
           // BundleConfig.RegisterBundles(BundleTable.Bundles);

              List<InventoryModel> Equipments = new List<InventoryModel>();
               InventoryModel Eq1 = new InventoryModel
               {
                   ID = "1",
                   Code = "C0001",
                   Catogery = "Laptop Computer",
                   Name = "DELL 13-inch"
               };

               InventoryModel Eq2 = new InventoryModel
               {
                   ID = "2",
                   Code = "C0002",
                   Catogery = "Computer",
                   Name =  "Mac Desktop "
               };

               InventoryModel Eq3 = new InventoryModel
               {
                   ID = "3",
                   Code = "P0003",
                   Catogery = "Printer ",
                   Name = "MNV Printer"
               };


               Equipments.Add(Eq1);
               Equipments.Add(Eq2);
               Equipments.Add(Eq3);

           Application["MyList"] = Equipments;



            List<string> categoryList = new List<string>();
            categoryList.Add("Printer");
            categoryList.Add("Laptop");
            categoryList.Add("Computer");

            Application["Category_List"] = categoryList;
            

































        }
    }
}
