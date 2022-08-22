using NUnit.Framework;
using NUnitForTesters.Services;
using System.Collections.Generic;

namespace NUnitForTesters.Test.Services
{
    public class CollectionServiceTests
    {
        [Test]
        public void TestEmptyConstructorForCollectionService()
        {
            var service = new CollectionService();
            CollectionAssert.IsNotEmpty(service.Names);
            CollectionAssert.AllItemsAreUnique(service.Names);
        }

        [Test]
        public void TestInitialsGenerator()
        {
            var names = new List<string> { "Michał Dobrzycki" };
            var service = new CollectionService(names);
            var initials = service.GetInitialsFromNames();

            CollectionAssert.AllItemsAreNotNull(initials);
            CollectionAssert.Contains(initials, "MD");
        }
    }
}
