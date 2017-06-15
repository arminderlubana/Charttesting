using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cureve.DAL;
using Cureve.Models.dynamic.Models;

namespace Cureve.Controllers
{
    public class ChartController : Controller
    {
        // GET: /Chart/

        public ActionResult Index()
        {
            ProductModel objProductModel = new ProductModel();
            //objProductModel.ProductData = new List<Product();
            objProductModel.ProductData = GetChartData();
            objProductModel.DateTitle = "Date";
            objProductModel.StartTitle = "Start";
            objProductModel.FinishTitle = "Finish";
            return View(objProductModel);

        }
        public Product GetChartData()
        {
           
            var  db = new ChartContext();
            var products = db.Product.ToList();

             Product objproduct = new Product();
            /*Get the data from databse and prepare the chart record data in string form.*/
            objproduct.Date = "2016/11/11,2016/11/09,2016/11/08,2016/11/07,2016/11/06,2016/11/05";
            objproduct.Start = "2000,1000,3000,1500,2300,500";
            objproduct.Finish = "2100,1400,2900,2400,2300,1500";
            products.Add(objproduct);
            return (objproduct);
        }
    }
}