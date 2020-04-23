using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication.DAL.Models;
using WebApplication.DAL.Repository.Wrapper;
using WebApplication.DTOs;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        private readonly IMapper _mapper;
        
        public BooksController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var books = _repoWrapper.Book.FindAll().ToList();
            return Ok(_mapper.Map<List<Book>, List<GetBookDTO>>(books));
        }

        [HttpPost]
        [Route("post")]
        public IActionResult Post(PostBookDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }

            var book = new Book
            {
                Title = model.Title,
                Language = model.Language,
                Pages = model.Pages,
                AuthorId = model.AuthorId,
                AgencyId = model.AgencyId
            };

            _repoWrapper.Book.Create(book);
            _repoWrapper.Save();
            return Ok();
        }
    }
}