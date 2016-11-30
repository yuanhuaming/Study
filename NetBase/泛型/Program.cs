using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using 泛型;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {


          var aaa=  null as List<string>;
 


            //sample1();

            Console.ReadKey();
        }

        public static void 泛型逆变()
        {

            //return models.ConvertAll<CustomerHotelInfoVModel>((input) => input);

            //return models.Select(a => a as CustomerHotelInfoVModel).ToList();
            //return AutoMapper.Mapper.Map<List<CustomerHotelInfoVModel>>(models);

            Func<string> foo = () => "泛型协变";
            Func<object> bar = foo;
            Console.WriteLine(bar());
        }

        public static void 泛型类型转换()
        {
        

            // 普通的类型转换
            Animal animal = new Dog(); //类型的隐式转换 
            Dog dog = (Dog)animal; //类型的强制转换
          
            // 泛型的类型转换
            IEnumerable<Animal> iAnimal = null;
            IEnumerable<Dog> iDog = null;
            //// “子类”向“父类”转换，即泛型接口的协变 out
            iAnimal = iDog;
            // “父类”向“子类”转换，即泛型接口的逆变  in ，
            //由于IEnumerable没有提供IEnumerable<in T>,所以编译时出错
            //iDog = iAnimal;
        }

        public class Animal
        {
        }
        public class Dog : Animal
        {
        }
  
        private static void sample1()
        {
            MyList arrayList = new MyList(1);
            arrayList[0] = arrayList[0] ?? new object();

            MyList<object> list = new MyList<object>(1);
            list[0] = list[0] ?? new object();

            Console.WriteLine("Here comes the testing code.");

            var a = arrayList[0];
            var b = list[0];

            Console.ReadLine();
  
        }



    
    }
 






}
