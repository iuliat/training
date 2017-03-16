using System;
using StringManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulationTests
{
    [TestClass]
    public class StrShiftTests
    {
        // LeftShifting Tests

        // rotates the last shift characters of a string to the left of the string
        // tests LeftShifting with shift characters where shift < length of the string
        [TestCategory("LeftShifting"), TestMethod]
        public void LeftShiftWithSmallNumber()
        {
            int shift = 2;
            // arrange  
            StrShift example = "Microsoft";
            var actualResult = example << shift;

            StrShift expectedResult = "ftMicroso";


            Assert.AreEqual(expectedResult, actualResult);
        }

        // rotates the last shift characters of a string to the left of the string
        // tests LeftShifting with shift characters where shift > length of the string
        [TestCategory("LeftShifting"), TestMethod]
        public void LeftShiftWithBigNumber()
        {
            StrShift example = "Microsoft";
            int shift = 11;

            var actualResult = example << shift;
            StrShift expectedResult = "ftMicroso";

            Assert.AreEqual(expectedResult, actualResult);
        }

        // rotates the last shift characters of a string to the left of the string
        // tests LeftShifting with 0
        [TestCategory("LeftShifting"), TestMethod]
        public void LeftShiftWithZero()
        {
            StrShift example = "Microsoft";
            int shift = 0;

            var actualResult = example << shift;
            StrShift expectedResult = "Microsoft";

            Assert.AreEqual(expectedResult, actualResult);
        }

        // rotates the last shift characters of a string to the left of the string
        // tests LeftShifting with negative number. Shifting with a negative number 
        // should result in RightShifting with absolute value of that number.
        [TestCategory("LeftShifting"), TestMethod]
        public void LeftShiftWithNegativeNumber()
        {
            StrShift example = "Microsoft";
            int shift = -2;

            var actualResult = example << shift;
            StrShift expectedResult = "crosoftMi";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("LeftShifting"), TestMethod]
        [ExpectedException(typeof(Exception), "Can't shift null object")]
        public void LeftShiftingNullObject()
        {
            StrShift example = null;
            var result = example << 3;
        }



        // RightShifting Tests

        // rotates the first shift characters of a string to the right of the string
        // tests RightShifting with shift characters where shift < length of the string
        [TestCategory("RightShifting"), TestMethod]
        public void RightShiftWithSmallNumber()
        {
            int shift = 2;
            // arrange  
            StrShift example = "Microsoft";
            var actualResult = example >> shift;

            StrShift expectedResult = "crosoftMi";


            Assert.AreEqual(expectedResult, actualResult);
        }

        // rotates the first shift characters of a string to the right of the string
        // tests RightShifting with shift characters where shift > length of the string
        [TestCategory("RightShifting"), TestMethod]
        public void RightShiftWithBigNumber()
        {
            StrShift example = "Microsoft";
            int shift = 11;

            var actualResult = example >> shift;
            StrShift expectedResult = "crosoftMi";

            Assert.AreEqual(expectedResult, actualResult);
        }

        // rotates the first shift characters of a string to the right of the string
        // tests RightShifting with 0
        [TestCategory("RightShifting"), TestMethod]
        public void RightShiftWithZero()
        {
            StrShift example = "Microsoft";
            int shift = 0;

            var actualResult = example >> shift;
            StrShift expectedResult = "Microsoft";

            Assert.AreEqual(expectedResult, actualResult);
        }

        // rotates the first shift characters of a string to the right of the string
        // tests RightShifting with negative number. Shifting with a negative number 
        // should result in LeftShifting with absolute value of that number.
        [TestCategory("RightShifting"), TestMethod]
        public void RightShiftWithNegativeNumber()
        {
            StrShift example = "Microsoft";
            int shift = -2;

            var actualResult = example >> shift;
            StrShift expectedResult = "ftMicroso";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("RightShifting"), TestMethod]
        [ExpectedException(typeof(Exception), "Can't shift null object")]
        public void RightShiftingNullObject()
        {
            StrShift example = null;
            var result = example >> 3;
        }



        // == Tests

        // tests equality between 2 different objects
        [TestCategory("Equality"), TestMethod]
        public void EqualityDifferentObjects()
        {
            StrShift example = "Microsoft";
            StrShift example2 = "Microsoft2";

            Boolean actualResult = example == example2;


            Assert.IsFalse(actualResult);
        }

        // tests equality between 2 objects
        [TestCategory("Equality"), TestMethod]
        public void EqualitySameObjects()
        {
            StrShift example = "Microsoft";
            StrShift example2 = "Microsoft";

            Assert.IsTrue(example == example2);
        }

        // tests equality between 2 different objects
        [TestCategory("Equality"), TestMethod]
        public void EqualitObjects()
        {
            StrShift example = "Microsoft";
            String example2 = "Microsoft2";

            Assert.IsFalse(example == example2);
        }

    }
}
