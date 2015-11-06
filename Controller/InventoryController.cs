using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
       
        public ActionResult Index()
        {
         
             List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"]; 
            ViewBag.MyList = Inv; 
             return View(); 
         } 
 
 
 
 
         public ViewResult Equpments(int ID)
         { 
             List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"]; 
             ViewBag.MyList = Inv; 

             ViewBag.ID = ID;
             
             return View(); 
         } 
 
 

        public ActionResult LaptopIndex()
        {
            List<InventoryModel> Laptops = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = "1",
                Code = "C0001",
                Name = "Laptop Computer",
                Description = "Dell XPS 13 Laptop",
            };

            Laptops.Add(Eq1);

            return View(Laptops);
        }


        public ActionResult ComputerIndex()
        {
            List<InventoryModel> Desktop = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = "2",
                Code = "C0002",
                Name = "Desktop Computer",
                Description = "Dell Inspiron 3000 i3646-2600BLK Desktop Computer ",
            };

            Desktop.Add(Eq1);

            return View(Desktop);
        }

        public ActionResult PrinterIndex()
        {
            List<InventoryModel> Printers = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = "3",
                Code = "P0003",
                Name = "Printers",
                Description = "Xerox WorkCentre 3215/NI Wireless Mono Laser Multifunction ",
            };

            Printers.Add(Eq1);

            return View(Printers);
        }


    }
}