using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLclassBuild;
using System.IO;

namespace XMLbuilderTests.XMLbuilderClassTest
{ 
    [TestClass]
    public class XMLclassTest
    {
        private XML rnd;

        [TestInitialize]
        public void InitializeXML()
        {
            rnd = new XML("C:\\Users\\MixD\\Desktop\\GitRepos\\HackBulgariaHomeworks\\HackTasksWeek6\\Tuesday\\test.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(XMLTagIsAlreadyOpen))]
        public void XMLCantOpenTagWithTheSameNameTwice()
        {
            rnd.OpenTag("xaxa");
            rnd.OpenTag("xaxa");
            rnd.Finish();
        } 
        
        [TestMethod]
        [ExpectedException(typeof(ThereAreNoOpenTags))]
        public void AttributeCantBeAddedIfThereAreNoOpenTags()
        {
            rnd.AddAtribute("xixo", "xoxo");
        }    
    }
}
