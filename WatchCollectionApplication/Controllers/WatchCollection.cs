using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WatchCollectionApplication.Controllers
{
    public class HelloWorldController: Controller
    {
       public string Index()
        {
            return "This is my default action...";
        }

        
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {ID}");
        }
    }
}
