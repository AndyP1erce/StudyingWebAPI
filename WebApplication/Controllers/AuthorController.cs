using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication.DAL.Models;
using WebApplication.DAL.Repository.Wrapper;
using WebApplication.DTOs;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/author")]
    public class AuthorController : Controller
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        
        public AuthorController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var authors = _repoWrapper.Author.FindAll().ToList();
            return Ok(_mapper.Map<List<Author>, List<GetAuthorDTO>>(authors));
        }

        [HttpPost]
        [Route("post")]
        public IActionResult Post(PostAuthorDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            
            _repoWrapper.Author.Create(new Author()
            {
                Id = new Guid(),
                Name = model.Name,
                Books = new List<Book>()
            });
            
            _repoWrapper.Save();
            return Ok();
        }
    }
}