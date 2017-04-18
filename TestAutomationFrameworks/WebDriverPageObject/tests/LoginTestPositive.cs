using NUnit.Framework;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebDriverPageObject
{
	[TestFixture()]
    public class LoginTestPositive : TestBase
	{
        
    	[Test, TestCaseSource("ValidCredentials")]
		public void LoginTestWithValidCredentials(AccountData account)
        {
            app.Auth.Login(account);
            Assert.IsTrue(app.Auth.IsLoggedIn(), "LoggedIn");
            app.Auth.Logout();
            Assert.IsTrue(app.Auth.IsLoggedOut(), "LoggedOut");
        }

        public static IEnumerable<AccountData> ValidCredentials()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"../../data/validCredentials.json"));
        }
    }
}
