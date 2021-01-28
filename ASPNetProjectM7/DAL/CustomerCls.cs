using ASPNetProjectM7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetProjectM7.DAL
{
    public class CustomerCls
    {
        Project7Database1Entities1 db = new Project7Database1Entities1();

        public IQueryable<CustomerTable> customerTables()
        {
            return from e in db.CustomerTables select e;
        }

        public void InsertCustomer(CustomerTable cusObj)
        {
            db.CustomerTables.Add(cusObj);
            db.SaveChanges();
        }

        public int UpdateCustomer(int Id, string CustomerName, string Age, string Email, string Address, string ImageUrl)

        {
            int count = 0;
            CustomerTable obj = db.CustomerTables.First(e => e.Id == Id);
            obj.CustomerName = CustomerName;
            obj.Age = Age;
            obj.Email = Email;
            obj.Address = Address;
            obj.ImageUrl = ImageUrl;
            count = db.SaveChanges();
            return count;

        }

        public int DeleteCustomer(int Id)

        {
            int count = 0;
            CustomerTable obj = db.CustomerTables.First(e => e.Id == Id);
            db.CustomerTables.Remove(obj);
            count = db.SaveChanges();
            return count;

        }
    }
}