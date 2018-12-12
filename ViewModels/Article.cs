using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace MvcMovie.ViewModels
{
    public class Article
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublicationDate { get; set; }

        public List<ArticleSection> Sections;
    }
}