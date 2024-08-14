using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riok.Mapperly.Abstractions;

namespace MapperlyDemo
{
    [Mapper]
    public partial class UserMapper
    {
        [MapProperty(nameof(User.Name), nameof(UserDto.FullName))]
        public partial UserDto MapToDto(User user);
    }

    //For custom mapping
    //[Mapper]
    //public partial class UserMapper
    //{
    //    [MapProperty(nameof(User.FirstName), nameof(UserDto.FullName))]
    //    public UserDto MapToDto(User user)
    //    {
    //        return new UserDto
    //        {
    //            FullName = $"{user.FirstName} {user.LastName}",
    //            Age = user.Age
    //        };
    //    }
    //}
}
