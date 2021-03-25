using Microsoft.AspNetCore.Mvc;
using MISA.QLTH.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.QLTH.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        IBaseService<T> _baseService;

        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }
        // GET: api/<BaseController>
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.GetTs();
            return Ok(entities);
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var entity = _baseService.GetTById(id);
            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return BadRequest("Không tìm thấy đối tượng theo Id");
            }
        }

        // POST api/<BaseController>
        [HttpPost]
        public IActionResult Post(T entity)
        {
            var serviceResult = _baseService.Add(entity);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.Success)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }

        // PUT api/<BaseController>/5
        [HttpPut]
        public IActionResult Put([FromBody] T entity)
        {
            var serviceResult = _baseService.Update(entity);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.Success)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var serviceResult = _baseService.Delete(id);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.Success)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }
    }
}
