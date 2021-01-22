using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Helper;
using DawAppWithAngular.Entities;
using DawAppWithAngular.IServices;
using DawAppWithAngular.Models;

namespace DawAppWithAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAll());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryService.Get(id));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Create(Category category)
        {
            var result = _categoryService.Create(category);
            return Ok(result);
        }

        // PUT api/<CategoryController>
        [HttpPut]
        public IActionResult Update(Category category)
        {
            return Ok(_categoryService.Update(category));
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_categoryService.Delete(id));
        }
    }


}
