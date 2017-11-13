using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GenreController : Controller
    {
        ApplicationDbContext _context;
        public GenreController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Genre
        public ActionResult Index()
        {
            var x = _context.Genres.ToList();
            return View(x);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Genre viewModel)
        {
            _context.Genres.Add(viewModel);
            _context.SaveChanges();
            return View();
        }

        public ActionResult Display(int id)
        {
            var x = _context.Genres.Single(g => g.Id == id);
            return View(x);
        }

        // GET: Genre
        public ActionResult Edit(int id)
        {
            var x = _context.Genres.Single(g => g.Id == id);
            return View(x);
        }

        [HttpPost]
        public ActionResult Edit(Genre viewModel)
        {
            //here we AreaReference reeiving ghe viewModel.ArtistId even though we have not sent it from the hidden fieed if CSHTML file"
            //var x = _context.Genres.Single(g => g.Id == id);
            return View();
        }
    }
}

// How does Social Login Works. We need to register the App with the facebook. They will give us one API key and a Secret key.
/*
 * Api-Key
 * Secret-Key
 * Now when a user wants to sign in frm out app, we will redirect to facebook using our API Key and Secret key so that facebook
 * knows that request is coming from a particular webapp. Now user puts his id and password. log in. 
 * after successful login, facebook knows the app address, so it will redirect user to videy and it will pass one autorization token
 * now this authorixation token tells our app the fb successfully authenticated the user. now again our app sends the API key and scret key and the auth token recd to the facebook
 * now facebook again verifies that auth token was really sent by him. facebook now gives us access token by which we can access some parts to user facebook datas (photo and all)
 * 
 */

/*
 * Enable SSL
 * Register the APP
 * press f4 in the project and set SSL to true, it will show one url. copy that url and right click the properct and in properties in web tab scroll down and replace mproject url with 
 * the new url. now sAve. now running the app and yes on the pop up. now adress bar should have https in address bar
 * 
*/