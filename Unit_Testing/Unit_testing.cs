using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle_Area_Calculator;
using NUnit.Framework;


namespace Unit_Testing
{
    [TestFixture]
    public class Unit_testing
    {

        [Test]
        public void TestGetLength_input3_expectLength3() //Testing GetLength() Method
        {
            int l = 3, w = 4;
            Rectangle testrectangle = new Rectangle(l,w);
            int length = testrectangle.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        public void TestSetLength_input3_expectLength3() //Testing SetLength() Method
        {
            int l = 3, w = 4;
            Rectangle testrectangle = new Rectangle(l, w);
            int length = testrectangle.SetLength(l);
            Assert.AreEqual(length, l);
        }

        [Test]
        public void TestGetWidth_input8_expectWidth8() //Testing GetWidth() Method
        {
            int l = 4, w = 8;
            Rectangle testrectangle = new Rectangle(l, w);
            int width = testrectangle.GetWidth();
            Assert.AreEqual(width, w);
        }

        [Test]
        public void TestSetWidth_input8_expectWidth8() //Testing SetWidth() Method
        {
            int l = 4, w = 8;
            Rectangle testrectangle = new Rectangle(l, w);
            int width = testrectangle.SetWidth(w);
            Assert.AreEqual(width, w);
        }

        [Test]
        public void TestPerimeter_input4_expectPerimeter16() //Testing GetPerimeter() Method
        {
            int l = 4, w = 4, p = 16;
            Rectangle testrectangle = new Rectangle(l, w);
            int perimeter = testrectangle.GetPerimeter();
            Assert.AreEqual(perimeter, p);
        }

        [Test]
        public void TestArea_input4_expectArea16() //Testing GetArea() Method
        {
            int l = 4, w = 4, a = 16;
            Rectangle testrectangle = new Rectangle(l, w);
            int area = testrectangle.GetArea();
            Assert.AreEqual(area, a);
        }

    }
}
