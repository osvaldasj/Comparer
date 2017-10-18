using Comparer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForComparer.UnitTestTextRecognition
{
    [TestClass]
    class UnitTestTextManager
    {
        TextManager textManager = new TextManager();
        // 

        [TestMethod]
        public void UnitTestTextManagerPrepareText(string text = "maxima")
        {
            text = textManager.PrepareText(text);

            Assert.IsTrue(text.Contains("maxima"));
        }

    }
}
