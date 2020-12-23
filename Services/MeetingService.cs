using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using kms_api.Models;

namespace kms_api.Services
{
    public class MeetingService : IMeetingService
    {
        public readonly KMSDBContext _context;
        public MeetingService(KMSDBContext context)
        {
            _context = context;
        }

        public List<Meeting> GetMeetings()
        {
            return _context.Meetings.
                    Include(m => m.Parts).ThenInclude(p => p.Publisher).
                    Include(m => m.Parts).ThenInclude(p => p.Assistant).
                    ToList();
        }

        public Meeting CreateMeeting(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            _context.SaveChanges();
            return _context.Meetings.Where(m => m.MeetingAt == meeting.MeetingAt).First();
        }
    }
}
