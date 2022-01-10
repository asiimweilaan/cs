using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CS
{
    class Program
    {
    static void Main(string[] args)
        {
            Employee E = new Employee();
            Console.WriteLine(E["Paul"]);
        }
    }
    public class Employee{
    public static List<Student> stud = new List<Student>(){
        new Student(){Name="Paul",Age=18},
        new Student(){Name="Roy",Age=21},
        new Student(){Name="Bethany",Age=47}
    };
    public int this[string x]{
        
        set{stud.FirstOrDefault(stud=>stud.Name==x).Name= value.ToString();}
        
        get{return stud.FirstOrDefault(stud=>stud.Name==x).Age;}
        

    }

    }
    public class Student{
    public string Name{get;set;}
    public int Age{get;set;}

    }
}