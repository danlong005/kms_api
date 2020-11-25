using System.Collections.Generic;
using System.Linq;
using kms_api.Models;
using Microsoft.EntityFrameworkCore;

namespace kms_api.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly KMSDBContext _context;

        public PublisherService(KMSDBContext context)
        {
            _context = context;
        }

        public List<Publisher> GetPublishers()
        {
            return _context.Publishers.ToList();
        }

        public Publisher CreatePublisher(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
            return _context.Publishers.
                Where(p => p.FirstName == publisher.FirstName && p.LastName == publisher.LastName && p.BaptizedAt == publisher.BaptizedAt && p.CongregationID == publisher.CongregationID).
                First();
        }
    }
}
