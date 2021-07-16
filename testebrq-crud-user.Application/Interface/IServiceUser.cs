using System;
using System.Collections.Generic;
using System.Text;
using TesteBRQ.CrudUsers.Util.DTO;

namespace testebrq_crud_user.Application.Interface
{
    public interface IServiceUser
    {
        void Add(UserDTO obj);

        List<UserDTO> GetAll();

        UserDTO GetById(int id);

        void Remove(int id);

        void Update(UserDTO obj);
    }
}
