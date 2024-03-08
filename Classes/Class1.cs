using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Thania Mathews
/// StID: ST10381071
/// Module: PROG6221
/// Date: 2024/02/26
/// </summary>

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

namespace ProgLecture3.Classes
{
    public class Class1
    {
        // creating strings - using access modifiers 
        private string privateVal = "Private";
        protected string protectedVal = "Protected";
        internal string internalVal = "Internal";
        protected internal string protectedInternalVal = "Protected Internal";
        public string publicVal = "Public";

        // defining method in class
        public void accessible()
        {
            Console.WriteLine("Class 1");
            Console.WriteLine(privateVal);
            Console.WriteLine(protectedVal);
            Console.WriteLine(internalVal);
            Console.WriteLine(protectedInternalVal);   
            Console.WriteLine(publicVal);
        }
    }

    // can create another class in same class 
    class Class2
    {
        Class1 cls2 = new Class1(); 

        public void accessible()
        {
            Console.WriteLine("Class 2");

            // Console.WriteLine(cls2.privateVal); - can't access private modifier
            // Console.WriteLine(cls2.protectedVal); - can't access protected modifier

            Console.WriteLine(cls2.internalVal);
            Console.WriteLine(cls2.protectedInternalVal);
            Console.WriteLine(cls2.publicVal);
        }
    }

    // don't need to create object  - use (:) to inherit from class 1
    class Class3 : Class1
    {
        public void accessible()
        {
            Console.WriteLine("Inherited Class 3");

            // Console.WriteLine(cls2.privateVal); - can't access private modifier
            // Console.WriteLine(cls2.protectedVal); - can't access protected modifier

            Console.WriteLine(internalVal);
            Console.WriteLine(protectedInternalVal);
            Console.WriteLine(publicVal);
        }
    }

}

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<*THE*END*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
