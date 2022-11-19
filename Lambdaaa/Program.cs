using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdaaa
{
    public static class ExtensionMethods
    {
        public static int toint(this string value)
        { return int.Parse(value); }
    }
    class Program
    {  
        static  List<student> _list= new List<student>();
        static student _stu = new student();

       
        public static void Main(string[] args)
        {

            Loggers.log("Main_system_started", "Main_Function", 1);
            _stu.Id = 1;
            _stu.Name = "faruk";
            _list.Add(_stu);
            foreach ( var su in _list)
            {
                Console.WriteLine("{0} and {1}", su.Id, su.Name);
               
            }
         
            Console.WriteLine("------------------------");
            infor("faruk");
            Console.ReadKey();
        }
        public static void infor(string name) 
        {
            Loggers.log("infor_started", id: 1);//start without second perameter just 3

            var far = _list.Find(kk=>kk.Name==name);
            Console.WriteLine("{0} and {1}", far.Id, far.Name);
            // return "faruk"; 
            Loggers.log("infor_off", "infor_Function", 3);
        }
    // static  bool predicate(student stdt) { return (stdt.Name == "faruk"); }

    }
    
    class student 
    {
        public int Id{ get; set; }
        public string Name { get; set; }
    }
}
