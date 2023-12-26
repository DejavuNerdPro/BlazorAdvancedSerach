
using BlazorAdvancedSerach.Models;
using System.Collections.Generic;

namespace BlazorAdvancedSerach.IServices
{
    interface IAddressService
    {
        public List<Address> getAllAddress();
        public Address getAddressById(int id);
        public List<Address> getAddressByUid(int uid);
        public Address getAddressByAddress(string address);
    }
}
