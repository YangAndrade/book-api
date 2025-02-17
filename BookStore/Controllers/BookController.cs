using BookStore.Communication.Request;
using BookStore.Communication.Responses;
using BookStore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost("Create")]
    [ProducesResponseType(typeof(ResponseCreateJson),StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody]RequestRegisterBookJson request)
    {
        var response = new ResponseCreateJson
        {
          Id = 1,
          Autrhor = request.Autrhor,
          Title = request.Title,
          Message = "Sucess to create a new book!"
        };

        return Created(string.Empty, response);
    }

    [HttpGet("get-all-books")]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]

    public IActionResult GetAllBooks()
    {
        var bookList = new List<Book>();

       bookList.Add( new Book()
        {
            Author = "Yang Andrade",
            Genre = "Aventura",
            Id = 1,
            Price = 80,
            Stok =1,
            Title = "Go Horse"
        });
        bookList.Add(new Book()
        {
            Author = "Amanda Quinto",
            Genre = "Poesia",
            Id = 1,
            Price = 80,
            Stok = 1,
            Title = "Astro-universo perdidos entre si"
        });
        return Ok(bookList);
    }

    [HttpPut("update-book")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateBook([FromRoute] int id, [FromBody]UpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete("delete-book")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBook([FromRoute] int id)
    {
        return NoContent();
    }


}
