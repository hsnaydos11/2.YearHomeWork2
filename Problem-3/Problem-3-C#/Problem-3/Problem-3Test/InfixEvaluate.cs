using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_3Library;
using System.Collections;
using System.Collections.Generic;

namespace Problem_3Test
{
    [TestClass]
    public class InfixEvaluate
    {
        [TestMethod]
        public void GoodCase()
        {
            int result = Problem_3Library.InfixEvaluate.EvaluateInfix.evaluate("(1 + 5) * (5 % (10 * 10))");
            Assert.AreEqual(500, result);
        }
        [TestMethod]
        public void BadCase()
        {
            int result = Problem_3Library.InfixEvaluate.EvaluateInfix.evaluate("(1 + 5) * (5 % (10 * 10))");
            Assert.AreNotEqual(550, result);
        }
        [TestMethod]
        public void UglyCase()
        {
            int result = Problem_3Library.InfixEvaluate.EvaluateInfix.evaluate("(1 + 5) * (5 % (10 * 10))");
            Assert.AreNotSame(500, result);
        }
    }
    [TestClass]
    public class InfixValidate
    {
        [TestMethod]
        public void GoodCase()
        {
            ArrayList arr = new ArrayList();
            arr.Add("a+b*(c^d-e)^(f+g*h)-i");
            foreach (string s1 in arr)
            {
                string s = s1;
                s = "(" + s + ")";
                s = s.Replace(" ", string.Empty);
                bool result = ValidateInfix.validate(s) == true;
                Assert.AreEqual(false, result);
            }
        }
        [TestMethod]
        public void BadCase()
        {
            ArrayList arr = new ArrayList();
            arr.Add("a+b*(c^d-e)^(f+g*h)-i");
            foreach (string s1 in arr)
            {
                string s = s1;
                s = "(" + s + ")";
                s = s.Replace(" ", string.Empty);
                bool result = ValidateInfix.validate(s) == true;
                Assert.AreNotEqual(true, result);
            }
        }
        [TestMethod]
        public void UglyCase()
        {
            ArrayList arr = new ArrayList();
            arr.Add("a+b*(c^d-e)^(f+g*h)-i");
            foreach (string s1 in arr)
            {
                string s = s1;
                s = "(" + s + ")";
                s = s.Replace(" ", string.Empty);
                bool result = ValidateInfix.validate(s) == true;
                Assert.AreNotSame(true, result);
            }
        }
    }
    [TestClass]
    public class InfixToPostfix
    {
        [TestMethod]
        public void GoodCase()
        {
            string exp = "a+b*(c^d-e)^(f+g*h)-i";
            string result = exp;
            Assert.AreEqual(result,exp);
        }
        [TestMethod]
        public void BadCase()
        {
            string exp = "a+b*(c^d-e)^(f+g*h)-i";
            string result = "abcd^e-fgh*+*+i-";
            Assert.AreNotEqual(result, exp);
        }
        [TestMethod]
        public void UglyCase()
        {
            string exp = "a+b*(c^d-e)^(f+g*h)-i";
            string result = "abcd^e-fgh*+*+i-";
            Assert.AreNotSame(result, exp);
        }
    }
}
