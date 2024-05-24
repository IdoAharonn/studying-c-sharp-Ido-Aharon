using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
//using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Ido_Aharon.object_basic
{
    public class ObjectTemplate
    {
        public int intProperty = 10;

        public string stringProperty = "some string";

        public bool boolProperty = false;

        public void ToggleBoolProperty()
        {
            boolProperty = !boolProperty;
        }



    }
    public class Car
    {
        public int engine = 2000;
        public string company = "mazda";
        public string model = "primum";
        public int price = 90000;
        public int year = 2020;
        public void DisplayDetails()
        {
            Console.WriteLine("Engine = {0}, company={1} , model={2} , price={3}, year={4}", engine, company, model, price, year);
        }
    }

    public class CarLot
    {
        public Car[] arr=new Car[10];
        public int SumWorkers = 17;
        public int HowMuchCar = 100;

    }

    public class TestBasicObject
    {

        public static void Demo()
        {
            ObjectTemplate template1 = new ObjectTemplate();


            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            template1.boolProperty = true;
            template1.stringProperty = "another string";
            template1.intProperty = 20;
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            ObjectTemplate template2 = new ObjectTemplate();

            Console.WriteLine("Template 2 = intProperty = {0} , string property = {1}, boolProperty ={2} "
               , template2.intProperty, template2.stringProperty, template2.boolProperty);
            Car car1 = new Car();
            car1.DisplayDetails();
            CarLot buyCar= new CarLot();
            buyCar.arr[0] = car1;
            Console.WriteLine("carLot=[SumWorkers={0} , HowMuchCar={1},arr= ]", buyCar.SumWorkers, buyCar.HowMuchCar );
            for(int i = 0; i < buyCar.arr.Length; i++)
            {
                if (buyCar.arr[i] != null)
                {
                    Console.WriteLine("car = ");
                    buyCar.arr[i].DisplayDetails();
                }
            }
            


        }
    }
}
