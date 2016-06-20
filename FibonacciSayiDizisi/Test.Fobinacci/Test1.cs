using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;

namespace Test.Fobinacci
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void GirilenIndeksDegeriniGoster()
        {
            var cikti = Sayilar.Islem(5);
            Assert.AreEqual(8, cikti);

            var cikti2 = Sayilar.Islem(2);
            Assert.AreEqual(2, cikti2);

            var cikti3 = Sayilar.Islem(10);
            Assert.AreEqual(89, cikti3);

            var cikti4 = Sayilar.Islem(7);
            Assert.AreEqual(21, cikti4);

            var cikti5 = Sayilar.Islem(20);
            Assert.AreEqual(10946, cikti5);
        }
    }
}
