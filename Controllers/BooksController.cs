using System.Threading.Tasks;
using api.DataAccess;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace api.Controllers
{
    public class BooksController : ControllerBase
    {
        private readonly DataContext _context;
        public BooksController(DataContext context)
        {
            _context = context;
        }
        [Route("api/addBooks")]
        [HttpPost]
        public async Task<IActionResult> booksAdd([FromBody]books b)
        {
            var booksObj = await _context.AddAsync(b).ConfigureAwait(false);
            if(await _context.SaveChangesAsync().ConfigureAwait(false) > 0)
            return Ok(booksObj);
            else
            return BadRequest("Registration failed on save.");
        }
        [Route("api/getall")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookList = await _context.Books.ToListAsync();

            return Ok(bookList);
        }
        [Route("api/update/{id}")]
        [HttpPut]

        public async Task<IActionResult> Update(int id, [FromBody]books b)
        {
            var booksData = await _context.Books.SingleOrDefaultAsync(d => d.Id == id);

            if(booksData != null){
                booksData.BookName = b.BookName;
                booksData.Author = b.Author;
                booksData.UpdatedAt = DateTime.Now;

                if(await _context.SaveChangesAsync() > 0)
                return CreatedAtRoute(new {booksData = booksData}, "Successfully Updated");
            }
            throw new Exception ($"Failed updating person id:{id}");
        }
        
        [Route("api/delete/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _context.Books.FindAsync(id);
            // var contacts = await _context.Books.Where(c => EF.Property<int>(c, "Id")==id).ToListAsync();
            // foreach (var contact in contacts)
            // {
            //     book.Remove(contact);
            // }   
            _context.Books.Remove(book);
            bool isDeleted = await _context.SaveChangesAsync() > 1;
            return Ok(isDeleted);
        }
    }
    
}