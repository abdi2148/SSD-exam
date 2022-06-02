using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "AdminAnn", EmailAddress = "ann.admin@email.com", Password = "1234", GivenName = "Ann", Surname = "Marie", Role = "Administrator" },
            new UserModel() { Username = "UserJoe", EmailAddress = "joe.seller@email.com", Password = "1234", GivenName = "Joe", Surname = "Doe", Role = "Seller" },
        };
    }
}
