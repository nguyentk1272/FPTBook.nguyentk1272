using FPTBook.Models;

using Microsoft.AspNetCore.Http;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.ViewModels
{
    public class BookGenreViewModel
    {
        public Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
