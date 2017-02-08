using System;
using System.Collections.Generic;

namespace Bibliothouris.Source.Users {
    public class UserRepository {

        private List<User> users;

        public UserRepository() {
            users = new List<User>();
            users.Add(new User(1234, "Xan"));
            users.Add(new User(5678, "Steven"));
            users.Add(new User(9012, "Thomas"));
        }

        public virtual List<User> GetAllUsers() {
            return users;
        }

        public virtual void AddUser(User user) {
            users.Add(user);
        }
    }
}