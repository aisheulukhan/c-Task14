using FileStream.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Serialize
            Product airport = new Product { Id = 1, Name = " iphone", Price = 200 };
            Product kondisoner = new Product { Id = 2, Name = "samsung", Price = 900 };
            Product adaptr = new Product { Id = 3, Name = "nokia", Price = 30 };
            OrderItem item1 = new OrderItem { Id = 1, Product = airport, Count = 2 };
            item1.TotalPrice = airport.Price * item1.Count;
            OrderItem item2 = new OrderItem { Id = 2, Product = adaptr, Count = 3 };
            item2.TotalPrice = kondisoner.Price * item2.Count;
            OrderItem item3 = new OrderItem { Id = 3, Product = kondisoner, Count = 4 };
            item3.TotalPrice = kondisoner.Price * item3.Count;
            List<OrderItem> orderItems1 = new List<OrderItem>();
            orderItems1.Add(item1);
            orderItems1.Add(item2);
            orderItems1.Add(item3);
            Order order1 = new Order { Id = 1, OrderItems = orderItems1 };
            var jsonObj = JsonConvert.SerializeObject(order1);
            Console.WriteLine(jsonObj);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\HP\Desktop\Tasks\FileStream\FileStream\Files\json1.json"))
            {
                sw.WriteLine(jsonObj);
            }
            #endregion
            #region Deserialize
            //string result;
            //using (StreamReader sr = new StreamReader(@"C:\Users\HP\Desktop\Tasks\FileStream\FileStream\Files\jsconfig1.json"))
            //{
            //    result = sr.ReadToEnd();
            //}
            //Order o1 = JsonConvert.DeserializeObject<Order>(result);
            //foreach (var item in o1.OrderItems)
            //{
            //    Console.WriteLine($"{item.Product.Id}  {item.Product.Name}   {item.Count}");
            //}

            #endregion
        }
    }
}
