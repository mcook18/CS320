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
            things.Clear();//inputs:Hello World, Expected outpupts: none,  postcondtions: none, execution history
        }
        public void Vectornumonly()
        {
            List<string> things = new List<string>();
            things.Add("1234567890");//ID:7, purpose:test short string nad of only numbers, Preconditions: have a vector created, 
            things.Clear();//inputs:1234567890, Expected outpupts: none,  postcondtions: none, execution history
        }
        public void Vectorstringcombo()
        {
            List<string> things = new List<string>();
            things.Add("1.26173587");//ID:8, Purpose:to test double variables , Preconditions: have a vector created, 
            things.Clear();//inputs:1.26173587, Expected outpupts: none,  postcondtions: none, execution history
        }
        public void Vectorendline()
        {
            List<string> things = new List<string>();
            things.Add("\n");//ID:9, Purpose:the new line character, Preconditions: have a vector created, 
            things.Clear();//inputs:\n, Expected outpupts: none,  postcondtions: none, execution history        
        }
        public void VectorAll()
        {
            List<string> things = new List<string>();
            things.Add("a7b3625 See \n Ñ 1.5748"); //ID:10, Purpose:test all of the types at once, Preconditions: have a vector created, 
            things.Clear();//inputs:a7b3625 See \n Ñ 1.5748, Expected outpupts: none,  postcondtions: none, execution history 

        }
        public void Vectorerase()
        {
            List<string> stuff = new List<string>();
            stuff.Add("");
            stuff.Remove("vector");
            stuff.Clear();
        }
        public void Vectorerase1()
        {
            List<string> stuff = new List<string>();
            stuff.Add("1");
            stuff.Remove("1");
            stuff.Clear();
        }
        public void VectorErase72()
        {
            List<string> stuff = new List<string>();
            stuff.Add("1");
            stuff.Remove("72");
            stuff.Clear();
        }
        public void VectorErasevec()
        {
            List<string> stuff = new List<string>();
            stuff.Add("1");
            stuff.Remove("Vector");
            stuff.Clear();
        }

        public void Vectorerase1num()
        {
            List<string> stuff = new List<string>();
            stuff.Add("vector");
            stuff.Remove("1");
            stuff.Clear();
        }
        public void vectorErasealtcode()
        {
            List<string> stuff = new List<string>();
            stuff.Add("vector");
            stuff.Remove("Ñ");
            stuff.Clear();
        }
        public void VectorErasevector()
        {
            List<string> stuff = new List<string>();
            stuff.Add("vector");
            stuff.Remove("vector");
            stuff.Clear();
        }
        public void Vectorerasepart()
        {
            List<string> stuff = new List<string>();
            stuff.Add("vector");
            stuff.Remove("vr");
            stuff.Clear();
        }
        public void Vectoreraseendline()
        {
            List<string> stuff = new List<string>();
            stuff.Add("vector");
            stuff.Remove("\n");
            stuff.Clear();
        }
        public void Vectorerasestuff()
        {
            List<string> stuff = new List<string>();
            stuff.Add("vector");
            stuff.Remove("see45");
            stuff.Clear();
        }
        public void VectorFind()
        {
            List<string> findme = new list<string>();
            findme.Add("A7b3625 see4 Ñ");
            findme.Find("Ñ");
            findme.Find("");
            findme.Find("7");
            findme.Find("35");
            findme.Find("A7b3625 see4 Ñ");
            findme.Find("0");
            findme.Find("a4");
            findme.Find("85");
            findme.Find("8 cross");
            findme.Find("cross");
        }
    }
}
