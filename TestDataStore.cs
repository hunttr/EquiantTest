using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tester.Models;

namespace Tester
{
    public class TestDataStore
    {
        public static TestDataStore Current { get; } = new TestDataStore();
        public List<Person> People { get; set; }

        public TestDataStore()
        {
            //init dummy data
            People = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Name = "Mom",
                    Description = "The matriarch"
                },
                new Person()
                {
                    Id = 2,
                    Name = "Dad",
                    Description = "The patriarch"
                },
                new Person()
                {
                    Id = 3,
                    Name = "Sibling",
                    Description = "Always one-upping you"
                }
            };
        }
    }
}