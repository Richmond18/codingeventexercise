using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{

    public class EventsController : Controller
    {
        static private List<Event> Events = new List<Event>();
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<Event> events = new List<Event>(EventData.GetAll());

            return View(events);
        }

        public IActionResult Add2()

        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        [HttpPost]
        [Route("Events/Add2")]

        public IActionResult Add2(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)

            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail
                };
                EventData.Add(newEvent);

                return Redirect("/Events");
            }
            return View(addEventViewModel);
        }

    
        

        

        
     
        


        public IActionResult Delete()
        {

            ViewBag.events = EventData.GetAll();
            
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int [] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }
    }
}
