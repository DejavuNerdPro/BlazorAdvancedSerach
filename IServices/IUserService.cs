using BlazorAdvancedSerach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvancedSerach.IServices
{
    interface IUserService
    {
        public List<User> getAllUser();
        public User getUserById(int id);
        public List<User> getUserByName(string name);
        public List<User> getUserByPhone(string phone);
        public List<User> getUserByAddress(string address);
        public List<User> getUserByAge(int age);

    }
}
