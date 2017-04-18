using NUnit.Framework;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace WebDriverPageObject
{
	[TestFixture()]
    public class LoginTestNegative : TestBase
	{
    	[Test(), TestCaseSource("InvalidCredentials")]
		public void LoginTestWithInvalidCredentials(AccountData account)
        {
            app.Auth.Login(account);
            Assert.IsTrue(app.Auth.IsLoggedOut(), "LoggedOut");
        }

        public static IEnumerable<AccountData> InvalidCredentials()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"../../data/invalidCredentials.json"));
        }
    }
}
