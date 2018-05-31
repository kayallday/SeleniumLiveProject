using System;
using NUnit.Framework;

namespace AutomatedSeleniumBase
{
    [TestFixture]
    public class AutomatedSeleniumBaseContext
    {
        public static TestContext Context { get; private set; }

        public static void AssemblyInit(TestContext context)
        {
            Context = context;
        }
    }
}