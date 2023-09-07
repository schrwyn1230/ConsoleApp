using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;


namespace UnitTestProject
{
    [TestClass]
    public class AreBracketsBalancedUnitTest
    {
        [TestMethod]
        public void SinglePairBracket()
        {
            //arrange
            var stringInput = "<>";

            //Act
            var result = Brackets.AreBracketsBalanced(stringInput);

            //assert
            //-True
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NoClosePairBracket()
        {
            //arrange
            var stringInput = "><";

            //Act
            var result = Brackets.AreBracketsBalanced(stringInput);

            //assert
            //-False(closed bracket can’t proceed all open brackets.)
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void OneBracketPairIsNotClosed()
        {
            //arrange
            var stringInput = "<<>";

            //Act
            var result = Brackets.AreBracketsBalanced(stringInput);

            //assert
            //- False (one bracket pair was not closed)
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NoBrackets()
        {
            //arrange
            var stringInput = "no brackets";

            //Act
            var result = Brackets.AreBracketsBalanced(stringInput);

            //assert
            // -True. (no brackets in the string will return True)
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SinglePairBracketWithStringInside()
        {
            //arrange
            var stringInput = "<abc...xyz>";

            //Act
            var result = Brackets.AreBracketsBalanced(stringInput);

            //assert
            // True (non-bracket characters are ignored appropriately)
            Assert.IsTrue(result);
        }
    }
}
