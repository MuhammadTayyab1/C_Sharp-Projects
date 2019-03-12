using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class  RestaurantMeal
    {
        string foodname;
        public int foodprice;

        public RestaurantMeal(string fn,int fp)
        {
            foodname = fn;
            foodprice = fp;
        }
        public void show()
        {
            Console.WriteLine(foodname);
            Console.WriteLine(foodprice);
        }
    }
    class  HotelService:RestaurantMeal
    {
        public string nameservice;
        public int servicefee;
        string roonno;

        public HotelService(string rno, string fn, int fp):base(fn,fp)
        {
            roonno = rno;
        }
        public void show1()
        {
            show();
            Console.WriteLine(roonno);
        }
    }
    class  RoomServiceMeal:HotelService
    {
        public RoomServiceMeal(string rno, string fn, int fp):base(rno,fn,fp)
        {
            nameservice = "Room service";
            servicefee = 700;
        }
        public void display()
        {
            show1();
            int total = servicefee + foodprice;
            Console.WriteLine(total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RoomServiceMeal obj = new RoomServiceMeal("45", "pizza", 800);
            obj.display();
        }


    }
}
