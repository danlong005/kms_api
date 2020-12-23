using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using kms_api.Models;

namespace kms_api.Services
{
    public class CongregationService : ICongregationService
    {
        private readonly KMSDBContext _context; 

        public CongregationService(KMSDBContext context)
        {
            _context = context;
        }

        public List<Congregation> GetCongregations()
        {
            return _context.Congregations.Include(c => c.Publishers).ToList();
        }

        public Congregation GetCongregationMeetings(int congregationId)
        {
            return _context.Congregations.Where(c => c.CongregationID == congregationId).
                Include(c => c.Meetings).ThenInclude(m => m.Parts).ThenInclude(p => p.Publisher).
                Include(c => c.Meetings).ThenInclude(m => m.Parts).ThenInclude(p => p.Assistant).First();
        }
    }
}
