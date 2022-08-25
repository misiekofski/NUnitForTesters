using NUnit.Framework;
using NUnitForTesters.Parallel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitForTesters.Test.Parallel
{
    // run all tests in parallel
    [Parallelizable(ParallelScope.Children)]
    public class HtmlTextFormatterTests
    {
        HtmlTextFormatter htf;
        [SetUp]
        public void SetUp()
        {
            htf = new HtmlTextFormatter();
        }

        [Test]
        public void TestBoldStuff()
        {
            var result = htf.FormatAsBold("Okazja!!!");
            StringAssert.IsMatch(result, "<b>Okazja!!!</b>");
        }

        [Test]
        public void TestItalicStuff()
        {
            var result = htf.FormatAsItalic("Okazja!!!");
            StringAssert.IsMatch(result, "<i>Okazja!!!</i>");
        }

        [Test]
        public void TestSmallStuff()
        {
            var result = htf.FormatAsSmall("Okazja!!!");
            StringAssert.IsMatch(result, "<small>Okazja!!!</small>");
        }

        [Test]
        public void TestDeletedStuff()
        {
            var result = htf.FormatAsDeleted("Okazja!!!");
            StringAssert.IsMatch(result, "<del>Okazja!!!</del>");
        }


        [Test]
        public void TestSubscriptStuff()
        {
            var result = htf.FormatAsSubscript("Okazja!!!");
            StringAssert.IsMatch(result, "<sub>Okazja!!!</sub>");
        }


        [Test]
        public void TestCustomStuff()
        {
            String result = htf.FormatAsCustomTag("Okazja!!!", "div");
            StringAssert.IsMatch(result, "<div>Okazja!!!</div>");
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(1500);
        }
    }
}
