using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebInvoiceService.BLL;

namespace WebInvoiceService.Controllers
{
    [System.Web.Mvc.Route("api/[controller]")]
    public class InvoiceController : ApiController
    {       
        // GET api/invoice
        public void Get()
        {
           
        }

        // POST api/invoice
        public void Post(string numberAgreement, float sumNewInvoice)
        {
            CreatingQueries queries = new CreatingQueries();
            queries.SelectAgreement(numberAgreement, sumNewInvoice);
        }
    }
}