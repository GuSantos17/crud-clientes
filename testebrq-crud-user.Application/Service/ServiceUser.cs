using System;
using System.Collections.Generic;
using System.Text;
using TesteBRQ.CrudUsers.Domain;
using TesteBRQ.CrudUsers.Domain.Models;
using TesteBRQ.CrudUsers.Infra.UnitOfWork;
using TesteBRQ.CrudUsers.Util.DTO;
using TesteBRQ.CrudUsers.Util.Interface;
using testebrq_crud_user.Application.Interface;

namespace testebrq_crud_user.Application.Service
{
    public class ServiceUser : IServiceUser
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperUser _mappperUser;

        public ServiceUser(IUserRepository repository, IUnitOfWork unitOfWork, IMapperUser mapperUser)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mappperUser = mapperUser;
        }

        public void Add(UserDTO obj)
        {
            try
            {
                User user = _mappperUser.MapperToEntity(obj);
                _repository.Add(user);
                _unitOfWork.Commit();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<UserDTO> GetAll()
        {
            return _mappperUser.MapperListUsers(_repository.GetAll());
        }

        public UserDTO GetById(int id)
        {
            var retorno = _repository.FindById(id);
            var retorno1 = _mappperUser.MapperToDTO(retorno);
            return
                retorno1;
        }

        public void Remove(int id)
        {
            try
            {
                _repository.Remove(_repository.FindById(id));
                _unitOfWork.Commit();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(UserDTO obj)
        {
            try
            {
                User user = _mappperUser.MapperToEntity(obj);
                _repository.Update(user);
                _unitOfWork.Commit();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
