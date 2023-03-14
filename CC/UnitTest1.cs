using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System;
using WSUnivercalLib;

namespace CC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                int pType = 3;
                int mType = 1;
                int count = 15;
                float width = 20;
                float length = 45;
                int setRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
                Assert.AreEqual(setRes, -1);
           }
            [TestMethod]
            public void invalid_material()
            {
                int pType = 3;
                int mType = 1;
                int count = 15;
                float width = 20;
                float length = 45;
                int setRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
                Assert.AreEqual(setRes, -1);
            }
            [TestMethod]
            public void count_lower_zero()
            {
                int pType = 3;
                int mType = 5;
                int count = -3;
                float width = 20;
                float length = 45;
                int setRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
                Assert.AreEqual(setRes, -1);
            }

            [TestMethod]
            public void calculate_heigth_width_value()
            {
                int pType = 3;
                int mType = 1;
                int count = 15;
                float width = 20;
                float length = 45;
                int setRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
                Assert.AreEqual(setRes, -1);
            }

            [TestMethod]
            public void Product_isnot_performed()
         {
            int pType = 3;
            int mType = 5;
            int count = 15;
            float width = 0;
            float length = 45;
            int setRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            Assert.AreEqual(setRes, -1);
        }
        [TestMethod]
        public void Performed_heigth_is_0_then_calc_is_not_performed()
        {
            int pType = 3;
            int mType = 5;
            int count = 15;
            float width = 20;
            float length = 0;
            int setRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            Assert.AreEqual(setRes, -1);
        }

        [TestMethod]
        public void Calc_width_int_and_height_value()
        {
            int pType = 2;
            int mType = 2;
            int count = 5;
            float width = 10;
            float length = 10;
            int setRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            Assert.AreEqual(setRes, -1);
        }

    }
}

