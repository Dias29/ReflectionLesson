using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 variant
            Type type = typeof(Program);

            //2 variant
            // Type type = Type.GetType("Полное имя типа"); 

            //3 variant
            //Type type = "Не обязательно строка".GetType();

            var membersInfo = type.GetMembers();
            //ConstructorInfo info ;

            //if(membersInfo = info.)

            foreach (var info in membersInfo)
            {

                Console.WriteLine(info.Name);
            }

            Console.ReadLine();


        }
    }
}
