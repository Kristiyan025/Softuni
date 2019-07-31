using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingSystem.Tests
{
    using NUnit.Framework;

    public class SoftParkTest
    {
        private SoftPark softpark;

        [SetUp]
        public void Setup()
        {
            softpark = new SoftPark();
        }

        [Test]
        public void ConstructorInitioalizationWorks()
        {
            for (char i = 'A'; i < 'C'; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string name = i + j.ToString();
                    Assert.AreEqual(null,softpark.Parking[name]);
                }
            }
        }

        [Test]
        public void ParkingPropertyWorks()
        {
            var t = new Dictionary<string, Car>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };
            Assert.AreEqual(t,softpark.Parking);
        }


        [Test]
        [TestCase("D2")]
        [TestCase("A2")]
        [TestCase("B2")]
        public void ParkCarMethodWorks(string spot )
        {
            Car car = new Car("lfwtgteef", "skwhe444");
            softpark.ParkCar("A2", new Car("fjkjh", "jhgrt"));
            if (!softpark.Parking.ContainsKey(spot))
            {
                Assert.Throws<ArgumentException>(() => softpark.ParkCar(spot, car));
                return;
            }else if (softpark.Parking[spot] != null)
            {
                Assert.Throws<ArgumentException>(() => softpark.ParkCar(spot, car));
                return;
            }

            bool carExists = softpark.Parking.Values
                .Any(x => x?.RegistrationNumber == car.RegistrationNumber);
            if (carExists)
                Assert.Throws<InvalidOperationException>(() => softpark.ParkCar(spot, car));
            string s = softpark.ParkCar(spot, car);
            Assert.AreEqual(car, softpark.Parking[spot]);
            Assert.AreEqual($"Car:{car.RegistrationNumber} parked successfully!", s);
        }

        [Test]
        [TestCase("A2")]
        [TestCase("D2")]
        [TestCase("B2")]
        public void RemoveCarMethodValidationWorks(string spot)
        {
            Car car = new Car("lfwtgteef", "skwhe444");
            softpark.ParkCar("A2", new Car("fjkjh", "jhgrt"));
            if (!softpark.Parking.ContainsKey(spot))
            {
                Assert.Throws<ArgumentException>(() => softpark.RemoveCar(spot, car));
                return;
            }
            if (softpark.Parking[spot] != car)
            {
                Assert.Throws<ArgumentException>(() => softpark.RemoveCar(spot, car));
                return;
            }
        }

        [Test]
        public void RemoveCarMathodWorks()
        {
            Car car = new Car("lfwtgteef", "skwhe444");
            softpark.ParkCar("A2", car);
            string s = softpark.RemoveCar("A2", car);
            Assert.AreEqual(null, softpark.Parking["A2"]);
            Assert.AreEqual("Remove car:skwhe444 successfully!", s);
        }
    }

}