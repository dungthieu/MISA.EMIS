using Microsoft.AspNetCore.Mvc;
using MISA.QLTH.ApplicationCore;
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
        public readonly IBaseService<T> _baseService;

        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }
        // GET: api/<BaseController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _baseService.GetAll();

            return StatusCode((int)result.MISACode, result);
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _baseService.GetById(id);
            return StatusCode((int)result.MISACode, result);
        }

        // POST api/<BaseController>
        [HttpPost]
        public IActionResult Post(T entity)
        {
            var result = _baseService.Create(entity);
            return StatusCode((int)result.MISACode, result);
        }

        // PUT api/<BaseController>/5
        [HttpPut]
        public IActionResult Put([FromBody] T entity)
        {
            var result = _baseService.Update(entity);
            return StatusCode((int)result.MISACode, result);
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var result = _baseService.Delete(id);
            return StatusCode((int)result.MISACode, result);
        }
        [HttpDelete]
        public IActionResult Delete(T entity)
        {
            var result = _baseService.Delete(entity);
            return StatusCode((int)result.MISACode, result);
        }
        [HttpDelete("range")]
        public IActionResult Delete(List<T> entities)
        {
            var result = _baseService.DeleteRange(entities);
            return StatusCode((int)result.MISACode, result);
        }
    }
}
