// See https://aka.ms/new-console-template for more information
using MapperlyDemo;

//var user = new User { FirstName = "John", LastName = "Doe", Age = 30 };

var user = new User { Name = "John", Age = 30 };
var mapper = new UserMapper();
UserDto userDto = mapper.MapToDto(user);

Console.WriteLine(userDto.FullName); // Output: John
Console.WriteLine(userDto.Age); // Output: 30

//Console.WriteLine(userDto.FullName); // Output: John Doe
