using BlazorAdvancedSerach.IServices;
using BlazorAdvancedSerach.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAdvancedSerach.Services
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext.DatabaseContext _databaseContext;

        public UserService(DatabaseContext.DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<User> getAllUser()
        {
            return _databaseContext.User.ToList();
        }

        public List<User> getUserByAddress(string address)
        {
            IAddressService addressService = new AddressService(_databaseContext);
            Address pickedAddress = addressService.getAddressByAddress(address);
            return _databaseContext.User.Where(u => u.Id == pickedAddress.Uid).ToList();
        }

        public List<User> getUserByAge(int age)
        {
            return _databaseContext.User.Where(user => user.Age == age).ToList();
        }

        public User getUserById(int id)
        {
            return _databaseContext.User.Find(id);
        }

        public List<User> getUserByName(string name)
        {
            return _databaseContext.User.Where(user => user.Name == name).ToList();
        }

        public List<User> getUserByPhone(string phone)
        {
            return _databaseContext.User.Where(user => user.Phone == phone).ToList();
        }
    }
}
