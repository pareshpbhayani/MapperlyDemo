using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyDemo
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class UserDto
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }
    // For custom mapping
    //public class User
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //}
}
