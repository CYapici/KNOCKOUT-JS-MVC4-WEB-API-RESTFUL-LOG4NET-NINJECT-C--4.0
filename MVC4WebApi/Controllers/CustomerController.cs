using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;
using MVC4WebApi.Models;


namespace MVC4WebApi.Controllers
{
    public class CustomersController : ApiController
    {
        public CustomersController() { }
        private ICustomerRepository repository;

        private static readonly ILog logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CustomersController(ICustomerRepository repository)
        { 
            this.repository = repository;
        }

        #region GET

        [Queryable]
        public IQueryable<Customer> GetCustomers()
        {
            return repository.Get().AsQueryable();
        }

        public Customer GetCustomer(int id)
        {
            Customer cust;
            if (!repository.TryGet(id, out cust))
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            return cust;
        }

        #endregion

        #region POST

        public HttpResponseMessage PostCustomer(Customer cust)
        {
            HttpResponseMessage response;
            decideUpdateOrCreate(cust, out response);
            return response;
        }

        #endregion

        #region DECIDEINSINGLEPOST

        private void decideUpdateOrCreate(Customer cust, out HttpResponseMessage response)
        {
            response = null;
            try
            {
                Customer temp;
                if (!repository.TryGet(cust.ID, out temp))
                {
                    cust = repository.Add(cust);
                    response = Request.CreateResponse<Customer>(HttpStatusCode.Created, cust);
                    response.Headers.Location = new Uri(Request.RequestUri, "/api/customers/" + cust.ID.ToString());

                }

                else
                {
                    repository.Update(cust);
                    response = (new HttpResponseMessage(HttpStatusCode.OK));
                }
            }
            catch (Exception ex)
            {
                string form = String.Format("ERROR OCCURRED IN {0}  STACK TRACE IS {1} MESSAGE  IS {2} ",
                    "decideUpdateOrCreate", ex.StackTrace, ex.Message);
                logger.Error(form, ex);

            }


        }

        #endregion

        #region DELETE
        public Customer DeleteCustomer(int id)
        {
            Customer comment;
            if (!repository.TryGet(id, out comment))
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            repository.Delete(id);
            return comment;
        }
        #endregion

        #region Paging GET
        public IEnumerable<Customer> GetCustomers(int pageIndex, int pageSize)
        {
            return repository.Get().Skip(pageIndex * pageSize).Take(pageSize);
        }
        #endregion

    }
}
