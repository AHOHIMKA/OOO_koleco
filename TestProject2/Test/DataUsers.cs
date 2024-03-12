using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Test
{
    public class DataUsers
    {
        private Dictionary<string, string> dataUsers = new Dictionary<string, string>();
        
        public DataUsers(){
            dataUsers.Add("userEmail1","passwordUser1");
            dataUsers.Add("userEmail2", "passwordUser2");
            dataUsers.Add("userEmail3", "passwordUser3");

        }

        public bool IsValidCredentials(string login, string password)
        {
            return dataUsers.ContainsKey(login) && dataUsers[login] == password;
        }

    }
}
