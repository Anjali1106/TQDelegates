using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // we will declare delegate in the namespace
    public delegate int MyDelegate(int x, int y);   // Variable name can be same or different

    public delegate string Mydelegate2(string name);
    public class Calculator
    {
        public int Add(int a, int b) { 
            return a + b;
        }

        public int Sub(int a, int b) { 
            return a - b; 
        }

        public int Multiply(int a, int b) { 
            return (a * b);
        }

        
    }
    public class User
    {
        public string AcceptName(string name) { 
            return name.ToUpper();
        }
    }
}
