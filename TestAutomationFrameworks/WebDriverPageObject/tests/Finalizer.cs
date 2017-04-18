using System;
using NUnit.Framework;

namespace WebDriverPageObject
{
    [SetUpFixture]
    public class Finalizer
    {
        [TearDown]
        public void RunInTheEndOfAll()
        {
            WebDriverFactory.DismissAll();
        }
    }
}