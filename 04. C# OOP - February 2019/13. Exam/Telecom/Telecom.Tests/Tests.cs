namespace Telecom.Tests
{
    using System;
    using NUnit.Framework;
    using Telecom;

    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("23/03/2019", "Android")]
        [TestCase("26/03/2019", "iPhone")]
        [TestCase("24/07/2019", "Huawei")]
        [TestCase("31/04/2019", "Android")]
        [TestCase("23/05/2019", "Sony")]
        [TestCase("21/02/2019", "Nokia")]
        public void TestConstructor(string make, string model)
        {
            var phone = new Phone(make,model);
            Assert.AreEqual(make,phone.Make);
            Assert.AreEqual(model, phone.Model);
        }

        [Test]
        [TestCase("fgn","fgef")]
        [TestCase("fg","fgtyref")]
        [TestCase("fgn","fgrheef")]
        [TestCase("gfn","fgefghghgdf")]
        [TestCase("fgef", "fgn")]
        [TestCase("fgtyre", "fgn")]
        [TestCase("yulukt", "fgn")]
        [TestCase("fgefghghgdf", "gfn")]
        public void TestNameAndModelValidationInConstructor(string make, string model)
        {
            var phone = new Phone(make, model);
            int c = phone.Count;
            phone.AddContact("djvbsk","3283463");
            Assert.AreEqual(c+1,phone.Count);
        }

        [Test]
        [TestCase("sfvs","fgvsfgv")]
        [TestCase("sdffvs","fgvsdfbfgv")]
        [TestCase("sffbsfvs","fgvfdbdsfgv")]
        [TestCase("sdfbdffvs","fgfbdvsfgv")]
        public void Ladjhkjh(string name, string phone)
        {
            var phodne = new Phone("dsh", "sdhsh");
            phodne.AddContact(name,phone);
            Assert.AreEqual($"Calling {name} - {phone}...", phodne.Call(name));
        }

    }
}