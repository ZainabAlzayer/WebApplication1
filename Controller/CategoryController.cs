using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Web.Caching;
//using InventoryModel.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {


        [HttpGet]
        public ActionResult AddCategory()
        {

            List<InventoryModel> Inventorystore = (List<InventoryModel>)HttpContext.Application["MyList"];
                       




            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(String category)
        {

            List<string> Catagory_List = (List<string>)HttpContext.Application["MyList"];
            Catagory_List.Add(category);




            return RedirectToAction("../Inventory/Index", category);
        }



// add Items.

        [HttpGet]
        public ViewResult AddItems()
        {
            List<string> Category_List = (List<string>)HttpContext.Application["Category_List"];
            ViewBag.Category_List = Category_List;

            List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"];

            

           





            return View();
        }

        [HttpPost]
        public ViewResult AddItems(InventoryModel inventory)
        {
            if (ModelState.IsValid)
            {

                List<string> Category_List = (List<string>)HttpContext.Application["Category_List"];
                ViewBag.Category_List = Category_List;



                List<InventoryModel> Inv = (List<InventoryModel>)HttpContext.Application["MyList"];
               
           


                return View("../Inventory/Index", inventory);
            } else

                return View();


        }
    }


    }




