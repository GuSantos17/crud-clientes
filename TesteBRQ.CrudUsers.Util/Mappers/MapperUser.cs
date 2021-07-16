using System;
using System.Collections.Generic;
using System.Text;
using TesteBRQ.CrudUsers.Domain.Models;
using TesteBRQ.CrudUsers.Util.DTO;
using TesteBRQ.CrudUsers.Util.Interface;

namespace TesteBRQ.CrudUsers.Util.Mappers
{
    public class MapperUser : IMapperUser
    {
        List<UserDTO> userDTOs = new List<UserDTO>();

        public User MapperToEntity(UserDTO userDTO)
        {
            User user = new User
            {
                IdUser = userDTO.Id,
                Nome = userDTO.Nome,
                Cpf = userDTO.Cpf,
                Email = userDTO.Email,
                Sexo = userDTO.Sexo,
                Telefone = userDTO.Telefone,
                DataNascimento = userDTO.DataNascimento
            };

            return user;
        }

        public List<UserDTO> MapperListUsers(IEnumerable<User> users)
        {
            foreach (var item in users)
            {
                UserDTO userDTO = new UserDTO
                {
                    Id = item.IdUser,
                    Nome = item.Nome,
                    Cpf = item.Cpf,
                    Email = item.Email,
                    Sexo = item.Sexo,
                    Telefone = item.Telefone,
                    DataNascimento = item.DataNascimento
                };

                userDTOs.Add(userDTO);

            }

            return userDTOs;
        }

        public UserDTO MapperToDTO(User user)
        {

            UserDTO userDTO = new UserDTO
            {
                Id = user.IdUser,
                Nome = user.Nome,
                Cpf = user.Cpf,
                Email = user.Email,
                Sexo = user.Sexo,
                Telefone = user.Telefone,
                DataNascimento = user.DataNascimento
            };

            return userDTO;

        }
    }
}
