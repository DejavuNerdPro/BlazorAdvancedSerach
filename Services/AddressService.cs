using BlazorAdvancedSerach.IServices;
using BlazorAdvancedSerach.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAdvancedSerach.Services
{
    public class AddressService : IAddressService
    {
        private readonly DatabaseContext.DatabaseContext _databaseContext;

        public AddressService(DatabaseContext.DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Address getAddressByAddress(string address)
        {
            return (Address)_databaseContext.Address.Where(a => a.address == address);
        }

        public Address getAddressById(int id)
        {
            return _databaseContext.Address.Find(id);
        }

        public List<Address> getAddressByUid(int uid)
        {
            return _databaseContext.Address.Where(address=>address.Uid==uid).ToList();
        }

        public List<Address> getAllAddress()
        {
            return _databaseContext.Address.ToList();
        }
    }
}
