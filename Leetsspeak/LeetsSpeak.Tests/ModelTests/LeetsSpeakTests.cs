using Microsoft.VisualStudio.TestTools.UnitTesting;
using Speak;

namespace LeetsSpeak.Tests
{
    [TestClass]
    public class LeetsSpeakTests
    {
        [TestMethod]
        public void ReplaceLetters_WillReplaceEveryLetter_true()
        {
            Generator newOneInstance = new Generator();
            Assert.AreEqual('O', newOneInstance.ReplaceLetters("o")[0]);
        }

        [TestMethod]
        public void ReplaceLetters_WillReplaceLetter_true()
        {
            Generator newOneO = new Generator();
            Assert.AreEqual('3', newOneO.ReplaceLetters("e")[0]);
        }
    }
}