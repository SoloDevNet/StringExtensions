using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloDev.StringExtensions.Tests
{

    [TestClass]
    public class SentenceTests
    {
        [TestMethod]
        public void FirstWordUpper_CorrectValue()
        {
            string sentence = "this is a Sentence.";
            string resultSentence = sentence.FirstWordUpper();
            
            Assert.AreEqual("This is a sentence.", resultSentence);
        }

        [TestMethod]
        public void FirstLetterUpper_CorrectValue()
        {
            string sentence = "this is a Sentence.";
            string resultSentence = sentence.FirstLetterUpper();

            Assert.AreEqual("This is a Sentence.", resultSentence);
        }

        [TestMethod]
        public void FirstLetterLower_CorrectValue()
        {
            string sentence = "THis Is A SenTence.";
            string resultSentence = sentence.FirstLetterLower();

            Assert.AreEqual("tHis Is A SenTence.", resultSentence);
        }

        [TestMethod]
        public void EveryWordUpper_CorrectValue()
        {
            string sentence = "this is a SenTence.";
            string resultSentence = sentence.EveryWordUpper();

            Assert.AreEqual("This Is A Sentence.", resultSentence);
        }

        [TestMethod]
        public void EveryLetterUpper_CorrectValue()
        {
            string sentence = "this is a SenTence.";
            string resultSentence = sentence.EveryLetterUpper();

            Assert.AreEqual("This Is A SenTence.", resultSentence);
        }

        [TestMethod]
        public void EveryLetterLower_CorrectValue()
        {
            string sentence = "tHis is a SenTence.";
            string resultSentence = sentence.EveryLetterLower();

            Assert.AreEqual("tHis is a senTence.", resultSentence);
        }

        [TestMethod]
        public void ContainsUpper_CorrectValue()
        {
            string sentence = "this 1s a SenTence.";
            bool result = sentence.ContainsUpper();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesntContainsUpper_CorrectValue()
        {
            string sentence = "this is a sentence.";
            bool result = sentence.ContainsUpper();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsLower_CorrectValue()
        {
            string sentence = "this 1s a SenTence.";
            bool result = sentence.ContainsLower();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesntContainLower_CorrectValue()
        {
            string sentence = "THIS 1S A SENTENCE.";
            bool result = sentence.ContainsLower();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsDigits_CorrectValue()
        {
            string sentence = "this 1s a SenTence.";
            bool result = sentence.ContainsDigits();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesntContainDigits_CorrectValue()
        {
            string sentence = "this is a SenTence.";
            bool result = sentence.ContainsDigits();

            Assert.IsFalse(result);
        }
    }
}
