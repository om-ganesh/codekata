using System;
using interviewcodings2018;
using NUnit.Framework;

namespace codingsunittests
{
    [TestFixture]
    public class IsStringsAnagramTest
    {
        [Test]
        public void AnagramWithDifferentWord()
        {
            String source = "test";
            String target = "tests";

            Assert.IsFalse(IsStringsAnagram.IsAnagram(source, target));
        }

        [Test]
        public void AnagramWithCapitalize()
        {
            String source = "TEST";
            String target = "sett";

            Assert.IsTrue(IsStringsAnagram.IsAnagram(source, target));
        }

        [Test]
        public void AnagramWithSingleCharacter()
        {
            String source = "h";
            String target = "H";

            Assert.IsTrue(IsStringsAnagram.IsAnagram(source, target));
        }

        [Test]
        public void AnagramWithLongString()
        {
            String source = "Welcometothewholelongstring";
            String target = "longstringtothewholewelcome";

            Assert.IsTrue(IsStringsAnagram.IsAnagram(source, target));
        }
    }
}
