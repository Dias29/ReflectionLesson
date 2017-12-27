using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynaminLibLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Users\УринбасаровД\Documents\Visual Studio 2017\Projects\ReflectionLesson\ReflectionLesson\bin\Debug\ReflectionLesson.exe");

            Type type = assembly.GetType("reflectionLesson.servIce", true, true);

            MethodInfo methodInfo = type.GetMethod("DestroyWorld");

            object service = Activator.CreateInstance(type);

            var result = methodInfo.Invoke(service, new object[] { "World will destroy in ", 15 });

            Console.ReadLine();


        }
    }
}
