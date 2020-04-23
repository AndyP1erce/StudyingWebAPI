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
    [Route("api/agency")]
    public class AgencyController : Controller
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        
        public AgencyController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var agencies = _repoWrapper.Agency.FindAll().ToList();
            return Ok(_mapper.Map<List<Agency>, List<GetAgencyDTO>>(agencies));
        }

        [HttpPost]
        [Route("post")]
        public IActionResult Post(PostAgencyDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            
            _repoWrapper.Agency.Create(new Agency()
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