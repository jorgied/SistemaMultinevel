using Sistema_Referidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Sistema_Referidos.Context;

namespace Sistema_Referidos.Controllers
{
    public class TableCustomerController: Controller
    {

        
        public ActionResult TableCustomer()
        {
            return View();

        }
     

        public JsonResult SaveOrder(TableCustomerVM O)
        {
            bool status = false;
            if (ModelState.IsValid)
            {

                using (ReferidosContext dc = new ReferidosContext())
                {
                    Table order = new Table { TableNro = O.TableNro, TableCustomerDate = O.TableCustomerDate, Description = O.Description };

                    dc.Tables.Add(order);
                    dc.SaveChanges();
                    
                    foreach (var i in O.CustomerAtTables)
                    {

                        CustomerAtTable cat = new CustomerAtTable();                        //
                        // i.TotalAmount = 
                        cat.NameCustomer = i.NameCustomer;
                        cat.NameRecomender = i.NameRecomender;
                        cat.DateAtTable = i.DateAtTable;
                        cat.idTable = order.idTable;

                        dc.CustomerAtTables.Add(cat);
                        dc.SaveChanges();

               
                    }
                
                    status = true;
                }
            }
            else
            {
                status = false;
            }
            return new JsonResult { Data = new { status = status } };
        }

    }

    




}
