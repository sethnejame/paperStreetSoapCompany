using System;
using Xunit;
using System.Collections.Generic;

namespace Common.Tests
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
           var changedItems = new LoggingServiceTest<ILoggable>();

           var customer = new Customer(1)
           {
             Email = "spacecommander@gmail.com",
             FirstName = "Charlie",
             LastName = "NeJame",
             AddressList = null
           };
           changedItems.Add(customer);

           var product = new Product(2)
           {
             ProductName = "Soap",
             ProductDescription = "Gets you clean after a fight",
             CurrentPrice = 7
           };
           changedItems.Add(product);

           LoggingService.WriteToFile(changedItems);
        }
    }
}
