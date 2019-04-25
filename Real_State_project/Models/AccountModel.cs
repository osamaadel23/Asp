using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Real_State_project.Models
{
    public class AccountModel
    {
        private List<account> listAccounts = new List<account>();

        public AccountModel()
        {
            listAccounts.Add(new account { username = "acc1", password = "123", roles = new string[] { "admin", "pm", "customer" } });
            listAccounts.Add(new account { username = "acc2", password = "123", roles = new string[] { "pm", "customer" } });
            listAccounts.Add(new account { username = "acc3", password = "123", roles = new string[] { "customer" } });
        }

        public account find(string username)
        {
            return listAccounts.Where(acc => acc.username.Equals(username)).FirstOrDefault();
        }

        public account login(string username, string password)
        {
            return listAccounts.Where(acc => acc.username.Equals(username) && acc.password.Equals(password)).FirstOrDefault();
        }
    }
    
}