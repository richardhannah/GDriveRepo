using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TestConsole
{
    public class TestClass
    {
        public string testvar = "test";
        public List<string> testList;
        public Dictionary<int, string> testDict;

        public TestClass()
        {
            testList = new List<string>();
            testDict = new Dictionary<int, string>();

            testList.Add("test1");
            testList.Add("test2");


            testDict.Add(1, "test3");
            testDict.Add(2, "test4");

            
        }
    }
}
