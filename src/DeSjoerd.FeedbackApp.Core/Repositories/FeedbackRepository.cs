using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeSjoerd.FeedbackApp.Core.Models;

namespace DeSjoerd.FeedbackApp.Core.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly FeedbackDataContext _dataContext;

        public FeedbackRepository(FeedbackDataContext dataContext)
        {
            if (dataContext == null) throw new ArgumentNullException(nameof(dataContext));

            _dataContext = dataContext;
        }

        public Task AddFeedback(Feedback feedback)
        {
            _dataContext.Feedbacks.Add(feedback);
            return _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Feedback>> List()
        {
            return await _dataContext.Feedbacks.ToAsyncEnumerable().ToList();
        }
    }
}
