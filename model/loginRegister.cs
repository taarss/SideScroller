using System;
using System.Collections.Generic;
using System.Text;
using SideScroller.model;

namespace SideScroller.model
{
    public class loginRegister
    {
        //Register a new account
        public void registerAccount(string username, string password)
        {
            if(!doesAccountWithNameExist(username)){
                using (var context = new SideScrollerDBContext())
                {
                    var account = new player()
                    {
                        Username = username,
                        Password = password,
                        CurrentScore = 0
                    };
                    context.Players.Add(account);

                    context.SaveChanges();
                }
            }
            
        }

        //Check if an account with the given name exists
        public bool doesAccountWithNameExist(string name)
        {
            using var context = new SideScrollerDBContext();

            foreach (var row in context.Players)
            {
                if(row.Username == name)
                {
                    return true;
                }
            }
            return false;
        }

        //Attempt login with the given credentials
        public bool login(string username, string password)
        {
            using var context = new SideScrollerDBContext();

            foreach (var row in context.Players)
            {
                if (row.Username == username && row.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
