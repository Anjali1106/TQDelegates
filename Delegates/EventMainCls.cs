﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void DisplayMessage();
    public class EventMainCls
    {
        static void PassMsg() {
            Console.WriteLine("Congrats! You are pass with good score");
        }

        static void FailMsg() {
            Console.WriteLine("OOPs! You are Fail");
        }

        //static void Main() {
        //    Student stud = new Student();
        //    // bind event with delegate/ configuration
        //    stud.Pass += new DisplayMessage(PassMsg);
        //    stud.Fail += new DisplayMessage(FailMsg);
        //    stud.AcceptMarks(30);
        //}
    }
}
