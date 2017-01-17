using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recurly;

namespace Recurly_API_Test
{
    [TestClass]
    public class AccountTests : BaseTest
    {

        [TestMethod]
        public void Add_Account()
        {
            // Get our account list count
            int accountsCount = Accounts.List().Count;
            
            // Create and save a new account
            var newAcct = Util.Generate_Random_Account();
            newAcct.Create();
            
            // Get the saved account and compare it to the new one we saved
            var storedAcct = Accounts.Get(newAcct.AccountCode);
            Assert.IsTrue(Util.Compare_Accounts(newAcct, storedAcct));

            // Verify the account list count went up by 1
            Assert.AreEqual(accountsCount + 1, Accounts.List().Count);
        }

    }
}
