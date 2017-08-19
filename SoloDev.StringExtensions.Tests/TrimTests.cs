using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SoloDev.StringExtensions.Tests
{
    [TestClass]
    public class TrimTests
    {
        [TestMethod]
        public void SplitSentence_FirstWord_CorrectValue()
        {
            string sentence = "This is a sentence.";
            string firstWord = sentence.FirstWord();

            Assert.AreEqual("This", firstWord);
        }

        [TestMethod]
        public void SplitSentence_FirstWordCustom_CorrectValue()
        {
            string sentence = "This is.a sentence";
            string firstWord = sentence.First('.');

            Assert.AreEqual("This is", firstWord);
        }

        [TestMethod]
        public void SplitSentence_LastWord_CorrectValue()
        {
            string sentence = "This is a sentence.";
            string lastWord = sentence.LastWord();

            Assert.AreEqual("sentence.", lastWord);
        }

        [TestMethod]
        public void SplitSentence_LastWordCustom_CorrectValue()
        {
            string sentence = "This is.a sentence";
            string lastWord = sentence.Last(".");

            Assert.AreEqual("a sentence", lastWord);
        }

        [TestMethod]
        public void SplitSentence_RangeWords_CorrectValue()
        {
            string sentence = "This is a longer sentence.";
            var words = sentence.Range(1, 3, ' ').ToList();

            CollectionAssert.AreEqual(new List<string> {
                "is", "a", "longer"
            }, words);
        }

        [TestMethod]
        public void SplitSentence_RangeWordsLonger_CorrectValue()
        {
            string sentence = "This is a quite longer and fuller sentence.";
            var words = sentence.Range(3, 6, ' ').ToList();

            CollectionAssert.AreEqual(new List<string> {
                "quite", "longer", "and", "fuller"
            }, words);
        }
    }
}
