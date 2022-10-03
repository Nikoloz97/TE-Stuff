using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass()]

    public class WordCountTests
    {
        [TestMethod()]
        public void GetCountTest()
        {
            WordCount nicksWordCount = new WordCount();
            Dictionary<string, int> actualOutput1 = nicksWordCount.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "ba", 2 }, { "black", 1 }, { "sheep", 1 } }, actualOutput1);

            Dictionary<string, int> actualOutput2 = nicksWordCount.GetCount(new string[] { });
            CollectionAssert.AreEqual(new Dictionary<string, int> {  }, actualOutput2);

            Dictionary<string, int> actualOutput3 = nicksWordCount.GetCount(new string[] { "a", "b", "a", "c", "b"});
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "a", 2 }, { "b", 2 }, { "c", 1 } }, actualOutput3);

            Dictionary<string, int> actualOutput4 = nicksWordCount.GetCount(new string[] { "c", "b", "a"});
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "c", 1 }, { "b", 1 }, { "a", 1 } }, actualOutput4);

            Dictionary<string, int> actualOutput5 = nicksWordCount.GetCount(new string[] { "a" });
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "a", 1 }}, actualOutput5);

        }
  


        }

    }

