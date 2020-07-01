using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceCore;

namespace UnitTests
{
    [TestClass]
    public class UnitTestXmlToJson
    {
        [TestMethod]
        public void TestXmlToJson1()
        {
            // XmlToJson("<foo>bar</foo>") must return { "foo": "bar" }
            Assert.AreEqual(@"{""foo"":""bar""}", Core.ConvertXmlToJson("<foo>bar</foo>", true));
        }
        [TestMethod]
        public void TestXmlToJson2()
        {
            // XmlToJson("<foo>hello</bar>") must return Bad Xml format
            Assert.AreEqual("Bad Xml format", Core.ConvertXmlToJson("<foo>hello</bar>", true));
        }
    }
}
