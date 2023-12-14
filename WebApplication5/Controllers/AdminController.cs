using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

namespace WebApplication5.Controllers
{
	public class AdminController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
		//USERS
		UserManager um = new UserManager(new EFUserRepository());
        public IActionResult UserList()
        {
            var values = um.ListAll();
            return View(values);
        }
        public IActionResult GetUser(User user)
        {
            using var c = new Context();
            var u = c.Users.Find(user.Id);

            return View("GetUser", u);

        }
        public IActionResult UpdateUser(User user)
        {
            using var c = new Context();
            var u = c.Users.Find(user.Id);
            u.Name = user.Name;
            u.Username = user.Username;
            u.Mail = user.Mail;
            c.Update(u);
            c.SaveChanges();

            return RedirectToAction("UserList");

        }
        public IActionResult RemoveUser(int id)
        {
            using var c = new Context();
            var user = c.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            c.Remove(user);
            c.SaveChanges();
            return RedirectToAction("UserList");
        }
        public IActionResult AddUsers()
        {
 
            return View();
        }

        public IActionResult AddUser(User user)
        {
            using var c = new Context();
            c.Add(user);
            c.SaveChanges();
            return RedirectToAction("UserList");
        }

        //MOVIE
        MovieManager mm = new MovieManager(new EFMovieRepository());
        public IActionResult MovieList()
        {
            var values = mm.GetMovieByCategory();
            return View(values);
        }
        public IActionResult MovieGet(Movie movie)
        {
            using var c = new Context();
            var u = c.Movies.Find(movie.Id);

            return View("MovieGet", u);

        }
        public IActionResult MovieUpdate(Movie movie)
        {
            using var c = new Context();
            var u = c.Movies.Find(movie.Id);
            u.Name = movie.Name;
            u.Genre = movie.Genre;
            u.Cast = movie.Cast;
            c.Update(u);
            c.SaveChanges();

            return RedirectToAction("MovieList");

        }
        public IActionResult MovieRemove(int id)
        {
            using var c = new Context();
            var movie = c.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            c.Remove(movie);
            c.SaveChanges();
            return RedirectToAction("MovieList");
        }
        public IActionResult MoviesAdd()
        {

            return View();
        }

        public IActionResult MovieAdd(Movie movie)
        {
            using var c = new Context();
            c.Add(movie);
            c.SaveChanges();
            return RedirectToAction("MovieList");
        }

        //CATEGORY
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult CategoryList()
        {
            var values = cm.ListAll();
            return View(values);
        }
        public IActionResult CategoryGet(Category category)
        {
            using var c = new Context();
            var u = c.Categorys.Find(category.Id);

            return View("CategoryGet", u);

        }
        public IActionResult CategoryUpdate(Category category)
        {
            using var c = new Context();
            var u = c.Categorys.Find(category.Id);
            u.Name = category.Name;
            u.color = category.color;
            c.Update(u);
            c.SaveChanges();

            return RedirectToAction("CategoryList");

        }
        public IActionResult CategoryRemove(int id)
        {
            using var c = new Context();
            var category = c.Categorys.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            c.Remove(category);
            c.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public IActionResult CategorysAdd()
        {
            return View();
        }

        public IActionResult CategoryAdd(Category category)
        {
            using var c = new Context();
            c.Add(category);
            c.SaveChanges();
            return RedirectToAction("CategoryList");
        }


        //CELEBRİTY
        CelebritiesManager cem = new CelebritiesManager(new EFCelebritiesRepository());
        public IActionResult CelebrityList()
        {
            var values = cem.ListAll();
            return View(values);
        }

        public IActionResult CelebrityGet(Celebrities celebrities)
        {
            using var c = new Context();
            var u = c.Celebrities.Find(celebrities.Id);

            return View("CelebrityGet", u);

        }
        public IActionResult CelebrityUpdate(Celebrities celebrities)
        {
            using var c = new Context();
            var u = c.Celebrities.Find(celebrities.Id);
            u.Name = celebrities.Name;
            u.Gender = celebrities.Gender;
            u.Age = celebrities.Age;
            u.Height = celebrities.Height;
            u.Bio = celebrities.Bio;
            u.Job = celebrities.Job;
            u.Image = celebrities.Image;
            u.BirthDate = celebrities.BirthDate;
            u.Country = celebrities.Country;
            c.Update(u);
            c.SaveChanges();

            return RedirectToAction("CelebrityList");

        }
        public IActionResult CelebritiesRemove(int id)
        {
            using var c = new Context();
            var celebrities = c.Celebrities.Find(id);
            if (celebrities == null)
            {
                return NotFound();
            }
            c.Remove(celebrities);
            c.SaveChanges();
            return RedirectToAction("CelebrityList");
        }
        public IActionResult CelebritiesAdd()
        {
            return View();
        }

        public IActionResult CelebrityAdd(Celebrities celebrities)
        {
            using var c = new Context();
            c.Add(celebrities);
            c.SaveChanges();
            return RedirectToAction("CelebrityList");
        }

        //SERIE
        SerieManager sm = new SerieManager(new EFSerieRepository());
        public IActionResult SerieList()
        {
            var values = sm.GetSerieByCategory();
            return View(values);
        }

        public IActionResult SerieGet(Serie serie)
        {
            using var c = new Context();
            var u = c.Series.Find(serie.Id);

            return View("SerieGet", u);

        }
        public IActionResult SerieUpdate(Serie serie)
        {
            using var c = new Context();
            var u = c.Series.Find(serie.Id);
            u.Name = serie.Name;
            u.Genre = serie.Genre;
            u.Director = serie.Director;
            u.Scenarist = serie.Scenarist;
            u.Cast = serie.Cast;
            u.Star = serie.Star;
            u.Image = serie.Image;
            u.Overview = serie.Overview;
            u.Date = serie.Date;
            u.Season = serie.Season;
            c.Update(u);
            c.SaveChanges();

            return RedirectToAction("SerieList");

        }
        public IActionResult SerieRemove(int id)
        {
            using var c = new Context();
            var serie = c.Series.Find(id);
            if (serie == null)
            {
                return NotFound();
            }
            c.Remove(serie);
            c.SaveChanges();
            return RedirectToAction("SerieList");
        }
        public IActionResult SeriesAdd()
        {
            return View();
        }

        public IActionResult SerieAdd(Serie serie)
        {
            using var c = new Context();
            c.Add(serie);
            c.SaveChanges();
            return RedirectToAction("SerieList");
        }


		//Rewiew
		RewiewManager rm = new RewiewManager(new EFRewiewRepository());
		public IActionResult RewiewList()
		{
			var values = rm.ListAll();
			return View(values);
		}

		public IActionResult RewiewGet(Rewiew rewiew)
		{
			using var c = new Context();
			var u = c.Rewiews.Find(rewiew.Id);

			return View("RewiewGet", u);

		}
		public IActionResult RewiewUpdate(Rewiew rewiew)
		{
			using var c = new Context();
			var u = c.Rewiews.Find(rewiew.Id);
			u.Title = rewiew.Title;
			u.Description = rewiew.Description;
			u.Writer = rewiew.Writer;
			u.Star = rewiew.Star;
			u.Date = rewiew.Date;
			u.MovieId = rewiew.MovieId;
			c.Update(u);
			c.SaveChanges();

			return RedirectToAction("RewiewList");

		}
		public IActionResult RewiewRemove(int id)
		{
			using var c = new Context();
			var rewiew = c.Rewiews.Find(id);
			if (rewiew == null)
			{
				return NotFound();
			}
			c.Remove(rewiew);
			c.SaveChanges();
			return RedirectToAction("RewiewList");
		}
		public IActionResult RewiewsAdd()
		{
			return View();
		}

		public IActionResult RewiewAdd(Rewiew rewiew)
		{
			using var c = new Context();
			c.Add(rewiew);
			c.SaveChanges();
			return RedirectToAction("RewiewList");
		}
	}
}
