using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloDev.StringExtensions.Tests
{
    [TestClass]
    public class CaseTests
    {
        #region Pascal Case

        [TestMethod]
        public void ToPascalCase_FromPascalCase()
        {
            string sentence = "ThisIsASentence";
            string result = sentence.ToPascalCase();

            Assert.AreEqual("ThisIsASentence", result);
        }

        [TestMethod]
        public void ToPascalCase_FromKebabCase()
        {
            string sentence = "this-is-a-sentence";
            string result = sentence.ToPascalCase();

            Assert.AreEqual("ThisIsASentence", result);
        }

        [TestMethod]
        public void ToPascalCase_FromCamelCase()
        {
            string sentence = "thisIsASentence";
            string result = sentence.ToPascalCase();

            Assert.AreEqual("ThisIsASentence", result);
        }

        [TestMethod]
        public void ToPascalCase_FromHungarianNotation()
        {
            string sentence = "this_is_a_sentence";
            string result = sentence.ToPascalCase();

            Assert.AreEqual("ThisIsASentence", result);
        }

        [TestMethod]
        public void ToPascalCase_FromNormalSentance()
        {
            string sentence = "This is a sentence";
            string result = sentence.ToPascalCase();

            Assert.AreEqual("ThisIsASentence", result);
        }

        [TestMethod]
        public void IsPascalCase_CorrectValue()
        {
            string sentence = "ThisIsASentence";
            bool result = sentence.IsPascalCase();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPascalCase_HasCamelCase_IncorrectValue()
        {
            string sentence = "thisIsASentence";
            bool result = sentence.IsPascalCase();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPascalCase_HasKebabCase_IncorrectValue()
        {
            string sentence = "this-is-a-sentence";
            bool result = sentence.IsPascalCase();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPascalCase_HasHungarianNotation_IncorrectValue()
        {
            string sentence = "this_is_a_sentence";
            bool result = sentence.IsPascalCase();

            Assert.IsFalse(result);
        }

        #endregion

        #region Camel Case

        [TestMethod]
        public void ToCamelCase_FromCamelCase()
        {
            string sentence = "thisIsASentence";
            string result = sentence.ToCamelCase();

            Assert.AreEqual("thisIsASentence", result);
        }

        [TestMethod]
        public void ToCamelCase_FromPascalCase()
        {
            string sentence = "ThisIsASentence";
            string result = sentence.ToCamelCase();

            Assert.AreEqual("thisIsASentence", result);
        }

        [TestMethod]
        public void ToCamelCase_FromKebabCase()
        {
            string sentence = "this-is-a-sentence";
            string result = sentence.ToCamelCase();

            Assert.AreEqual("thisIsASentence", result);
        }

        [TestMethod]
        public void ToCamelCase_FromHungarianNotation()
        {
            string sentence = "this_is_a_sentence";
            string result = sentence.ToCamelCase();

            Assert.AreEqual("thisIsASentence", result);
        }

        [TestMethod]
        public void ToCamelCase_FromNormalSentance()
        {
            string sentence = "This is a sentence";
            string result = sentence.ToCamelCase();

            Assert.AreEqual("thisIsASentence", result);
        }

        [TestMethod]
        public void IsCamelCase_CorrectValue()
        {
            string sentence = "thisIsASentence";
            bool result = sentence.IsCamelCase();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCamelCase_HasPascalCase_IncorrectValue()
        {
            string sentence = "ThisIsASentence";
            bool result = sentence.IsCamelCase();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsCamelCase_HasKebabCase_IncorrectValue()
        {
            string sentence = "this-is-a-sentence";
            bool result = sentence.IsCamelCase();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsCamelCase_HasHungarianNotation_IncorrectValue()
        {
            string sentence = "this_is_a_sentence";
            bool result = sentence.IsCamelCase();

            Assert.IsFalse(result);
        }

        #endregion

        #region Kebab Case

        [TestMethod]
        public void ToKebabCase_FromKebabCase()
        {
            string sentence = "this-is-a-sentence";
            string result = sentence.ToKebabCase();

            Assert.AreEqual("this-is-a-sentence", result);
        }

        [TestMethod]
        public void ToKebabCase_FromCamelCase()
        {
            string sentence = "thisIsASentence";
            string result = sentence.ToKebabCase();

            Assert.AreEqual("this-is-a-sentence", result);
        }

        [TestMethod]
        public void ToKebabCase_FromPascalCase()
        {
            string sentence = "ThisIsASentence";
            string result = sentence.ToKebabCase();

            Assert.AreEqual("this-is-a-sentence", result);
        }

        [TestMethod]
        public void ToKebabCase_FromHungarianNotation()
        {
            string sentence = "this_is_a_sentence";
            string result = sentence.ToKebabCase();

            Assert.AreEqual("this-is-a-sentence", result);
        }

        [TestMethod]
        public void ToKebabCase_FromNormalSentance()
        {
            string sentence = "This is a sentence";
            string result = sentence.ToKebabCase();

            Assert.AreEqual("this-is-a-sentence", result);
        }

        [TestMethod]
        public void IsKebabCase_CorrectValue()
        {
            string sentence = "this-is-a-sentence";
            bool result = sentence.IsKebabCase();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsKebabCase_HasPascalCase_IncorrectValue()
        {
            string sentence = "ThisIsASentence";
            bool result = sentence.IsKebabCase();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsKebabCase_HasCamelCase_IncorrectValue()
        {
            string sentence = "thisIsASentence";
            bool result = sentence.IsKebabCase();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsKebabCase_HasHungarianNotation_IncorrectValue()
        {
            string sentence = "this_is_a_sentence";
            bool result = sentence.IsKebabCase();

            Assert.IsFalse(result);
        }

        #endregion

        #region Kebab Case

        [TestMethod]
        public void ToHungarianNotation_FromHungarianNotation()
        {
            string sentence = "this_is_a_sentence";
            string result = sentence.ToHungarianNotation();

            Assert.AreEqual("this_is_a_sentence", result);
        }

        [TestMethod]
        public void ToHungarianNotation_FromCamelCase()
        {
            string sentence = "thisIsASentence";
            string result = sentence.ToHungarianNotation();

            Assert.AreEqual("this_is_a_sentence", result);
        }

        [TestMethod]
        public void ToHungarianNotation_FromPascalCase()
        {
            string sentence = "ThisIsASentence";
            string result = sentence.ToHungarianNotation();

            Assert.AreEqual("this_is_a_sentence", result);
        }

        [TestMethod]
        public void ToHungarianNotation_FromKebabCase()
        {
            string sentence = "this-is-a-sentence";
            string result = sentence.ToHungarianNotation();

            Assert.AreEqual("this_is_a_sentence", result);
        }

        [TestMethod]
        public void ToHungarianNotation_FromNormalSentance()
        {
            string sentence = "This is a sentence";
            string result = sentence.ToHungarianNotation();
            
            Assert.AreEqual("this_is_a_sentence", result);
        }

        [TestMethod]
        public void IsHungarianNotation_CorrectValue()
        {
            string sentence = "this_is_a_sentence";
            bool result = sentence.IsHungarianNotation();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsHungarianNotation_HasPascalCase_IncorrectValue()
        {
            string sentence = "ThisIsASentence";
            bool result = sentence.IsHungarianNotation();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsHungarianNotation_HasCamelCase_IncorrectValue()
        {
            string sentence = "thisIsASentence";
            bool result = sentence.IsHungarianNotation();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsHungarianNotation_HasKebabCase_IncorrectValue()
        {
            string sentence = "this-is-a-sentence";
            bool result = sentence.IsHungarianNotation();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ToSlug_FromNormalSentance()
        {
            string sentence = "This is a sentence!";
            string result = sentence.Slugify();

            Assert.AreEqual("this-is-a-sentence", result);
        }

        #endregion


    }
}
