using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook() //object initializer syntax
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artist = new Artists[]
                {
                    new Models.Artists() {Name = "Dan Slott", Role = "Script" },
                    new Models.Artists() {Name = "Humberto Ramos", Role = "Pencils" },
                    new Models.Artists() {Name = "Victor Olazaba", Role = "Inks" },
                    new Models.Artists() {Name = "Edgar Delgado", Role = "Colors" },               
                    new Models.Artists() {Name = "Chris Eliopoulos", Role = "Letters" },
                }

        };          
     
            return View(comicBook); 
        }
    }
}