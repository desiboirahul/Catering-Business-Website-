using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Mail;

namespace pizzashop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DoWork()
        {

        }
        public string CreateFood(string FoodN, string FoodPrice, string FoodQ, string email)
        {
            using (ist420row1Entities entities = new ist420row1Entities())
            {
                Food FD = new Food();            
                FD.FoodName = FoodN;
                FD.Price = Convert.ToInt32(FoodPrice);
                FD.Quantity = Convert.ToInt32(FoodQ);
                entities.Foods.Add(FD);
                entities.SaveChanges();

                if (FD.FoodId > 0)
                    return FD.FoodId.ToString();
                else
                    return "false";



            }
        }
        //    public bool UpdateCreateFood(string FoodN, string FoodPrice, string FoodQ)
        //    {
        //        using (ist420row1Entities entities = new ist420row1Entities())
        //        {
        //            Food FD = new Food();
        //            FD = entities.Foods.Find(FoodN);
        //            FD.FoodName = (FoodN == null) ? FD.FoodName : FoodN;
        //            FD.Price = (Convert.ToInt32(FoodPrice) == 0) ? FD.Price : Convert.ToInt32(FoodPrice);
        //            FD.Quantity = (Convert.ToInt32(FoodQ) == 0) ? FD.Quantity : Convert.ToInt32(FoodQ);

        //            entities.SaveChanges();
        //            if (FD.FoodId > 0)
        //                return true;
        //            else
        //                return false;
        //        }
        //    }
        //    public FD ReadFood()
        //}
    }
}
