using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.ViewModels;

namespace MvcMovie.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            var article = new Article()
            {
                Title = "Mi Articulo",
                AuthorName = "Abraham Lincoln",
                PublicationDate = DateTime.Now,
                Sections = new List<ArticleSection>
                {
                    new ArticleSection{
                        Title = "Indice de la seccion uno",
                        Content = "Puntuacion de cuatro y hace seis años..."
                    },
                    new ArticleSection{
                        Title = "Indice de la seccion dos",
                        Content = "Ahora nos encontramos en una verdadera guerra civil, probando...."
                    },
                    new ArticleSection{
                        Title = "Indice de la seccion tres",
                        Content = "Pero, en un sentido amplio, no nos podemos dedicar..."
                    }
                },

            };


            return View(article);
        }
    }
}