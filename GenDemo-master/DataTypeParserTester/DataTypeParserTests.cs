using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsRevision;

namespace DataTypeParserTester
{
    [TestClass]
    public class DataTypeParserTests
    {
        [TestMethod]
        public void DataTypeParser_Validate_Boolean_True()
        {
            Assert.IsTrue(DataTypeParser.ParseBool("true"));
        }
        [TestMethod]
        public void DataTypeParser_Validate_Boolean_False()
        {
            Assert.IsFalse(DataTypeParser.ParseBool("false"));
        }
        [TestMethod]
        public void DataTypeParser_Validate_Boolean_Incorrect_String()
        {
            Assert.IsFalse(DataTypeParser.ParseBool("qwerty"));
        }
        [TestMethod]
        public void DataTypeParser_Validate_Parse_Integer_Incorrect_Entry()
        {
            Assert.AreEqual(0, DataTypeParser.Parse("erfeerg", DataType.Int));
        }
        [TestMethod]
        public void DataTypeParser_Validate_Parse_Integer_Correct_Entry()
        {
            Assert.AreEqual(1000000, DataTypeParser.Parse("1000000", DataType.Int));
        }
    }
}
