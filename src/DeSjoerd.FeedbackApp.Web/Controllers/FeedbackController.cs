using DeSjoerd.FeedbackApp.Core.Models;
using DeSjoerd.FeedbackApp.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeSjoerd.FeedbackApp.Web.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackRepository _feedbackRepo;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            if (feedbackRepository == null) throw new ArgumentNullException(nameof(feedbackRepository));

            _feedbackRepo = feedbackRepository;
        }

        public IActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Feedback newFeedback)
        {
            await _feedbackRepo.AddFeedback(newFeedback);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            var feedback = await _feedbackRepo.List();
            return View(feedback);
        }
    }
}
