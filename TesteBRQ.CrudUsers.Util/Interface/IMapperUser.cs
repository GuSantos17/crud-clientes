using System.Collections.Generic;
using TesteBRQ.CrudUsers.Domain.Models;
using TesteBRQ.CrudUsers.Util.DTO;

namespace TesteBRQ.CrudUsers.Util.Interface
{
    public interface IMapperUser
    {
        User MapperToEntity(UserDTO userDTO);

        List<UserDTO> MapperListUsers(IEnumerable<User> users);

        UserDTO MapperToDTO(User user);
    }
}
