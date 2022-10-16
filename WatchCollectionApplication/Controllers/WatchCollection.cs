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

        public string Welcome()
        {
            return "this is the Welcome action method...";
        }
    }
}
