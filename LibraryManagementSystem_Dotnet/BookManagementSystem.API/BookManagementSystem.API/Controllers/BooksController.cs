using BookManagementSystem.API.Models.Domain;
using BookManagementSystem.API.Models.DTO;
using BookManagementSystem.API.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        private readonly IGenreRepository genreRepository;
        private readonly IApplicationUserRepository applicationUserRepository;

        public BooksController(IBookRepository bookRepository, 
            IGenreRepository genreRepository,
            IApplicationUserRepository applicationUserRepository)
        {
            this.bookRepository = bookRepository;
            this.genreRepository = genreRepository;
            this.applicationUserRepository = applicationUserRepository;
        }

        [HttpPost]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookRequestDTO request)
        {

            string userId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;

            //convert DTO to domain model
            
                var book = new Book
                {
                    Name = request.Name,
                    Author = request.Author,
                    Description = request.Description,
                    FeaturedImageUrl = request.FeaturedImageUrl,
                    IsAvailable = request.IsAvailable,
                    UrlHandle = request.UrlHandle,
                    Genres = new List<Genre>(),
                    LentByUserId = userId
                };
            

            foreach (var genreGuid in request.Genres)
            {
                var existingGenre = await genreRepository.GetById(genreGuid);
                if (existingGenre is not null)
                {
                    book.Genres.Add(existingGenre);
                }
            }

            book = await bookRepository.CreateAsync(book);

            //convert domain model back to dto
            var response = new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Description = book.Description,
                FeaturedImageUrl = book.FeaturedImageUrl,
                IsAvailable = book.IsAvailable,
                LentByUserId = book.LentByUserId,
                UrlHandle = book.UrlHandle,
                Genres = book.Genres.Select(x => new GenreDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    UrlHandle = x.UrlHandle
                }).ToList()
            };

            return Ok(response);
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await bookRepository.GetAllAsync();

            // Convert Domain model to DTO
            var response = new List<BookDTO>();
            foreach (var book in books)
            {
                response.Add(new BookDTO
                {
                    Id = book.Id,
                    Author = book.Author,
                    FeaturedImageUrl = book.FeaturedImageUrl,
                    IsAvailable = book.IsAvailable,
                    Description = book.Description,
                    LentByUserId = book.LentByUserId,
                    CurrentlyBorrowedByUserId = book.CurrentlyBorrowedByUserId,
                    Name = book.Name,
                    UrlHandle = book.UrlHandle,
                    Genres = book.Genres.Select(x => new GenreDTO
                    {
                        Id = x.Id,
                        Name = x.Name,
                        UrlHandle = x.UrlHandle
                    }).ToList()

                });
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetBookById([FromRoute] Guid id)
        {
            // Get the Book from Repo
            var book = await bookRepository.GetByIdAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            // Convert Domain Model to DTO
            var response = new BookDTO
            {
                Id = book.Id,
                Author = book.Author,
                FeaturedImageUrl = book.FeaturedImageUrl,
                IsAvailable = book.IsAvailable,
                Description = book.Description,
                LentByUserId = book.LentByUserId,
                CurrentlyBorrowedByUserId = book.CurrentlyBorrowedByUserId,
                Name = book.Name,
                UrlHandle = book.UrlHandle,
                Genres = book.Genres.Select(x => new GenreDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    UrlHandle = x.UrlHandle
                }).ToList()
            };

            return Ok(response);
        }

        [HttpGet]
        [Route("{urlHandle}")]
        public async Task<IActionResult> GetBookByUrlHandle([FromRoute] string urlHandle)
        {
            // Get book details from repository
            var book = await bookRepository.GetByUrlHandleAsync(urlHandle);

            if (book is null)
            {
                return NotFound();
            }

            // Convert Domain Model to DTO
            var response = new BookDTO
            {
                Id = book.Id,
                Author = book.Author,
                FeaturedImageUrl = book.FeaturedImageUrl,
                IsAvailable = book.IsAvailable,
                Description = book.Description,
                Name = book.Name,
                UrlHandle = book.UrlHandle,
                Genres = book.Genres.Select(x => new GenreDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    UrlHandle = x.UrlHandle
                }).ToList()
            };

            return Ok(response);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> UpdateBookById([FromRoute] Guid id, UpdateBookRequestDTO request)
        {
            // Convert DTO to Domain Model
            var book = new Book
            {
                Id = id,
                Author = request.Author,
                FeaturedImageUrl = request.FeaturedImageUrl,
                IsAvailable = request.IsAvailable,
                Description = request.Description,
                Name = request.Name,
                UrlHandle = request.UrlHandle,
                Genres = new List<Genre>()
            };

            // Foreach 
            foreach (var genreGuid in request.Genres)
            {
                var existingGenre = await genreRepository.GetById(genreGuid);

                if (existingGenre != null)
                {
                    book.Genres.Add(existingGenre);
                }
            }


            // Call Repository To Update Book Domain Model
            var updatedBook = await bookRepository.UpdateAsync(book);

            if (updatedBook == null)
            {
                return NotFound();
            }

            // Convert Domain model back to DTO
            var response = new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Description = book.Description,
                FeaturedImageUrl = book.FeaturedImageUrl,
                IsAvailable = book.IsAvailable,
                UrlHandle = book.UrlHandle,
                Genres = book.Genres.Select(x => new GenreDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    UrlHandle = x.UrlHandle
                }).ToList()
            };

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> DeleteBook([FromRoute] Guid id)
        {
            var deletedBook = await bookRepository.DeleteAsync(id);

            if (deletedBook == null)
            {
                return NotFound();
            }

            // Convert Domain model to DTO
            var response = new BookDTO
            {
                Id = deletedBook.Id,
                Name = deletedBook.Name,
                Author = deletedBook.Author,
                Description = deletedBook.Description,
                FeaturedImageUrl = deletedBook.FeaturedImageUrl,
                IsAvailable = deletedBook.IsAvailable,
                UrlHandle = deletedBook.UrlHandle,
            };

            return Ok(response);
        }

        [HttpPost]
        [Authorize]
        [Route("BorrowBook/{bookId}")]
        public async Task<ActionResult> BorrowBook([FromRoute] Guid bookId)
        {
            if (bookId == null) return BadRequest();

            string userId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;

            var BorrowUser = await applicationUserRepository.GetByIdAsync(userId);

            var book = await bookRepository.GetByIdAsync(bookId);

            if (book == null) return NotFound();

            var LentUser = await applicationUserRepository.GetByIdAsync(book.LentByUserId);
            if (LentUser == null)
            {
                // Handle the case where LentUser is null
                return NotFound();
            }
            if (book.IsAvailable == false)
            {
                book.CurrentlyBorrowedByUserId = null;
                await bookRepository.UpdateAsync(book);
                //BorrowUser.TokensAvailable += 1;
                book.IsAvailable = true;
                await applicationUserRepository.UpdateAsync(BorrowUser);
                return Ok(BorrowUser.TokensAvailable);
            }
            else 
            {
                if (BorrowUser.TokensAvailable < 1)
                {
                    return BadRequest("Tokens Not Available to Borrow Book");
                    //return BadRequest(new BookBorrowResponse(
                    //    Result: false,
                    //    error: "Tokens Not Available to Borrow Book",
                    //    TokenCount: BorrowUser.TokensAvailable
                    //));
                }
                else if(book.LentByUserId == BorrowUser.Id)
                {
                    return BadRequest("You can't borrow this book");
                }

                book.CurrentlyBorrowedByUserId = userId;
                LentUser.TokensAvailable += 1;
                BorrowUser.TokensAvailable -= 1;
                book.IsAvailable = false;
                await bookRepository.UpdateAsync(book);
                await applicationUserRepository.UpdateAsync(BorrowUser);
                await applicationUserRepository.UpdateAsync(LentUser);
                return Ok(BorrowUser.TokensAvailable);
                //return Ok(new BookBorrowResponse(
                //        Result: true,
                //        error: null,
                //        TokenCount: BorrowUser.TokensAvailable
                //    ));

            }


        }

    }
}
