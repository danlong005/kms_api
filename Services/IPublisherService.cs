﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kms_api.Models;

namespace kms_api.Services
{
    public interface IPublisherService
    {
        List<Publisher> GetPublishers();

        Publisher CreatePublisher(Publisher publisher);
    }
}
