using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
   public  class Service1
    {


       public static void SaveOrder(int type)
       {
           
           //order.AddOrder 添加订单
           //order.AddCashLog
           if (type==1)
           {
               //hotel.addhotelInfo  
           }
           else if (type==2)
           {
               //ticket.addticketInfo
           }
           {
               //...
           }

       }
    }

   public class Service2
   {


       public static void SaveHotelOrder()
       {

           //order.AddOrder 添加订单
           //order.AddCashLog
           //hotel.addhotelInfo  

       }
       public static void SaveTicketOrder()
       {

           //order.AddOrder 添加订单
           //order.AddCashLog
           //ticket.addticketInfo 
       }
   }

   public class BaseService
   {


       public static void SaveOrder(Action action)
       {

           //order.AddOrder 添加订单
           //order.AddCashLog
           action();

       }
 
   }
   public class Service3 : BaseService
   {

       public static void SaveHotelOrder()
       {
         //  SaveOrder(hotel.addhotelInfo);
       }

       public static void SaveTicketOrder()
       {
         //  SaveOrder(hotel.addhotelInfo);
       }

   }
  
 
}
