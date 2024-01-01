using BlazorAdvancedSerach.Models;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BlazorAdvancedSerach.Utitlity
{
    public class UserEqualityComparer : IEqualityComparer<UserDTO>
    {
        public bool Equals(UserDTO x, UserDTO y)
        {
            return x.id == y.id;
        }

        public int GetHashCode([DisallowNull] UserDTO obj)
        {
            return obj.id.GetHashCode();
        }
    }
}
