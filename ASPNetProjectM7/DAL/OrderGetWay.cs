using ASPNetProjectM7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetProjectM7.DAL
{
    public class OrderGetWay
    {
        Project7Database1Entities2 db = new Project7Database1Entities2();

        public IQueryable<OrderTable> orderTables()
        {
            return from e in db.OrderTables select e;
        }

        public void InsertOrder(OrderTable orderObj)
        {
            db.OrderTables.Add(orderObj);
            db.SaveChanges();
        }

        public int UpdateOrder(int OrderId, int Id, string Categorys, decimal ProductQty, DateTime OrderDate, decimal TotalAmount, decimal PaidAmount, decimal DueAmount, DateTime DeliveryDate)

        {
            int count = 0;
            OrderTable obj = db.OrderTables.First(e => e.OrderId == OrderId);
            obj.Id = Id;
            obj.Categorys = Categorys;
            obj.ProductQty = ProductQty;
            obj.OrderDate = OrderDate;
            obj.TotalAmount = TotalAmount;
            obj.PaidAmount = PaidAmount;
            obj.DueAmount = DueAmount;
            obj.DeliveryDate = DeliveryDate;
            count = db.SaveChanges();
            return count;

        }

        public int DeleteOrder(int OrderId)

        {
            int count = 0;
            OrderTable obj = db.OrderTables.First(e => e.OrderId == OrderId);
            db.OrderTables.Remove(obj);
            count = db.SaveChanges();
            return count;

        }
    }
}