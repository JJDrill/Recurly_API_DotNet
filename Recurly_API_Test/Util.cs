using System;
using Recurly;

namespace Recurly_API_Test
{
    class Util
    {

        public static Account Generate_Random_Account()
        {
            var newAcctCode = "API " + DateTime.Now;
            newAcctCode = newAcctCode.Replace("/", "-");
            var randAddress = EfficientlyLazy.IdentityGenerator.Generator.GenerateAddress();
            var randName = EfficientlyLazy.IdentityGenerator.Generator.GenerateName();
            var randFirst = Util.UppercaseFirst(randName.First);
            var randLast = Util.UppercaseFirst(randName.Last);
            Random rnd = new Random();
            var randPhone = "(" + rnd.Next(500, 999) + ")" +
                            " " + rnd.Next(201, 999) +
                            "-" + rnd.Next(1000, 9999);
            var randVAT = rnd.Next(100000000, 999999999).ToString();
            var account = new Account(newAcctCode);
            
            account.Username = newAcctCode;
            account.FirstName = randFirst;
            account.LastName = randLast;
            account.CompanyName = randLast + " Inc.";
            account.Email = randFirst + randLast + "@somedomain.com";
            account.CcEmails = randFirst + randLast + "@anotherdomain.com";
            account.VatNumber = randVAT;

            Address address = new Address();
            address.Country = "United States";
            address.Address1 = randAddress.AddressLine;
            address.Address2 = RandomGen.Gen.Random.Text.Short().Invoke();
            address.Phone = randPhone;
            address.City = randAddress.City;
            address.State = randAddress.StateName;
            address.Zip = randAddress.ZipCode;
            account.Address = address;
            
            return account;
        }

        public static Boolean Compare_Accounts(Account acct1, Account acct2)
        {
            if (acct1.AccountCode != acct2.AccountCode)
            {
                return false;
            }
            else if (acct1.Username != acct2.Username)
            {
                return false;
            }
            else if (acct1.FirstName != acct2.FirstName)
            {
                return false;
            }
            else if (acct1.LastName != acct2.LastName)
            {
                return false;
            }
            else if (acct1.CompanyName != acct2.CompanyName)
            {
                return false;
            }
            else if (acct1.Email != acct2.Email)
            {
                return false;
            }
            else if (acct1.CcEmails != acct2.CcEmails)
            {
                return false;
            }
            else if (acct1.VatNumber != acct2.VatNumber)
            {
                return false;
            }
            else if (acct1.Address.Country != acct2.Address.Country)
            {
                return false;
            }
            else if (acct1.Address.Address1 != acct2.Address.Address1)
            {
                return false;
            }
            else if (acct1.Address.Address2 != acct2.Address.Address2)
            {
                return false;
            }
            else if (acct1.Address.Phone != acct2.Address.Phone)
            {
                return false;
            }
            else if (acct1.Address.City != acct2.Address.City)
            {
                return false;
            }
            else if (acct1.Address.State != acct2.Address.State)
            {
                return false;
            }
            else if (acct1.Address.Zip != acct2.Address.Zip)
            {
                return false;
            }
            else if (acct1.State != acct2.State)
            {
                return false;
            }
            else if (acct1.CreatedAt != acct2.CreatedAt)
            {
                return false;
            }

            return true;
        }

        public static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            s = s.ToLower();
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
