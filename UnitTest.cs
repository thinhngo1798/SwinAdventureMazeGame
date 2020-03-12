//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;


//namespace CaseStudy2.Test
//{
//    [TestFixture()]
//    public class UnitTest
   
//    {
//        private Player ids = new Player(new string {"fred"},"");
//        [Test()]
//        public void TestAreYou()
//        {
//            Assert.IsTrue(ids.AreYou("fred"));
//           // Assert.IsTrue(ids.AreYou("bob"));
//        }
//        [Test()]
//        public void TestNotAreYou()
//        {
//            Assert.IsFalse(ids.AreYou("Steven"));
//        }
//        [Test()]
//        public void TestCaseSensitive()
//        {
//            Assert.IsTrue(ids.AreYou("FRED"));
//            Assert.IsTrue(ids.AreYou("bOB"));

//        }
//        [Test()]
//        public void TestFirstID()
//        {
//           Assert.AreEqual(ids.FirstId,"fred");

//        }
//        [Test()]
//        public void TestAddID()
//        {
//            ids.AddIdentifier("wilma");
//            Assert.IsTrue(ids.AreYou("wilma"));

            

//        }
//    }
//}
