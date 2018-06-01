using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.Models
{
    interface IDAO
    {
        User GetUser(int id);
        List<User> GetUserList();

        void AddUser(User user);
        void DeleteUser(int id);
        void EditUser(User user);
        void Dispose();


    }
}
