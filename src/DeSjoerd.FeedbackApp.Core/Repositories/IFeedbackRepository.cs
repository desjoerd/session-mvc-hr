using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeSjoerd.FeedbackApp.Core.Models;

namespace DeSjoerd.FeedbackApp.Core.Repositories
{
    public interface IFeedbackRepository
    {
        Task<IEnumerable<Feedback>> List();

        Task AddFeedback(Feedback feedback);
    }
}
