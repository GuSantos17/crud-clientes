using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteBRQ.CrudUsers.Util.DTO;
using testebrq_crud_user.Application.Interface;

namespace testebrq_crud_users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IServiceUser _serviceUser;

        public UserController(IServiceUser serviceUser)
        {
            _serviceUser = serviceUser;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> Get()
        {
            return Ok(_serviceUser.GetAll());
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<UserDTO> GetById(int id)
        {
            return Ok(_serviceUser.GetById(id));
        }

        //POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                _serviceUser.Add(userDTO);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] UserDTO userDTO, int id)
        {
            try
            {
                userDTO.Id = id;
                if (userDTO == null)
                {
                    return NotFound();
                }
                _serviceUser.Update(userDTO);
                return Ok("Usuario Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound();

                _serviceUser.Remove(id);
                return Ok("Usuario Removido com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
