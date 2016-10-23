using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls.Primitives;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace EX05_01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Vectorpushbackempty()
        {
            List<string> things= new List<string>();
            things.Add("");// ID:1 , Purpose:test an empty string, Preconditions: have vector created, 
            things.Clear(); //inputs: empty string, expected output:no output, postcondtions: none, execution history
           
        }

        public void Vectorpushbacksinglenum()
        {
            List<string> things= new List<string>();
            things.Add("1");// ID:2 , Purpose:test single number, Preconditions: have vector created,
            things.Clear(); //inputs: 1, expected output:no output, postcondtions: none, execution history
        }

        public void Vectorpushbackchar()
        {
            List<string>things=new List<string>();
            things.Add("a");// ID:3 , Purpose:test single character, Preconditions: have vector created,
            things.Clear();//inputs: a, expected output:no output, postcondtions: none, execution history
        }

        public void Vectorpushbacksymbol()
        {
            List<string>things=new List<string>();
            things.Add("!");//ID:4, purpose:test single symbol, Preconditions: have a vector created, 
            things.Clear();//inputs:!, Expected outpupts: none,  postcondtions: none, execution history
        }

        public void Vectorpbaltcode()
        {
            List<string> things= new List<string>();
            things.Add("Ñ");//ID:5, purpose:test alt code symbols, Preconditions: have a vector created, 
            things.Clear();//inputs:Ñ, Expected outpupts: none,  postcondtions: none, execution history
        }

        public void VectorPBstringspace()
        {
            List<string>things= new List<string>();
            things.Add("Hello World");//ID:6, purpose:test short string with space, Preconditions: have a vector created, 
            things.Clear();//inouts:Hello World, Expected outpupts: none,  postcondtions: none, execution history
        }
        public void Vectorerase()
        {
            List<string> stuff = new List<string>();
            stuff.Add("1");
            stuff.Remove("vector");
        }
    }
}
