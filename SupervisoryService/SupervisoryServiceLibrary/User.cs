using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SupervisoryServiceLibrary
{
    public enum Role
    {
        Administrator, Writer, Reader
    }
    public class User
    {
        //User: Id, Email, Username, Password, Role
        public int Id { get; set; } = 0;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
}
