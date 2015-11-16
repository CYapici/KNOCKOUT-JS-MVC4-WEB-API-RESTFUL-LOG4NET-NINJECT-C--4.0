using System;
using System.Collections.Generic;
using System.Linq;
using log4net;

///
/// ON AIR ( RAM )  CRUD OPERATIONS  
/// 
/// 
namespace MVC4WebApi.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        long nextID;
        public Dictionary<long, Customer> Customers = new Dictionary<long, Customer>();

        public long NextId
        {
            get { return nextID; }
            set { nextID = value; }
        }

        public IEnumerable<Customer> Get()
        {
            try
            {
                return Customers.Values.OrderBy(cust => cust.ID);
            }
            catch (Exception ex)
            {
                string form = String.Format("ERROR OCCURRED IN {0}  STACK TRACE IS {1} MESSAGE  IS {2} ",
                    "decideUpdateOrCreate", ex.StackTrace, ex.Message);
                logger.Error(form, ex);
                return new List<Customer>();

            }

        }

        public bool TryGet(long id, out Customer cust)
        {
            try
            {
                return Customers.TryGetValue(id, out cust);
            }
            catch (Exception ex)
            {
                string form = String.Format("ERROR OCCURRED IN {0}  STACK TRACE IS {1} MESSAGE  IS {2} ",
                    "decideUpdateOrCreate", ex.StackTrace, ex.Message);
                logger.Error(form, ex);
                cust = null;
                return false;

            }

        }

        public Customer Add(Customer cust)
        {


            try
            {
                cust.ID = nextID++;
                Customers[cust.ID] = cust;
            }
            catch (Exception ex)
            {
                string form = String.Format("ERROR OCCURRED IN {0}  STACK TRACE IS {1} MESSAGE  IS {2} ",
                    "decideUpdateOrCreate", ex.StackTrace, ex.Message);
                logger.Error(form, ex);


            }

            return cust;
        }

        public bool Delete(long id)
        {
            try
            {
                return Customers.Remove(id);
            }
            catch (Exception ex)
            {
                string form = String.Format("ERROR OCCURRED IN {0}  STACK TRACE IS {1} MESSAGE  IS {2} ",
                    "decideUpdateOrCreate", ex.StackTrace, ex.Message);
                logger.Error(form, ex);
                return false;

            }

        }

        public bool Update(Customer cust)
        {
            bool update = Customers.ContainsKey(cust.ID);

            //threads can cause assgn error
            try
            {
                Customers[cust.ID] = cust;
            }
            catch (Exception ex)
            {
                string form = String.Format("ERROR OCCURRED IN {0}  STACK TRACE IS {1} MESSAGE  IS {2} ",
                    "decideUpdateOrCreate", ex.StackTrace, ex.Message);
                logger.Error(form, ex);

            }

            return update;
        }
    }
}