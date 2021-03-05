using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


    [ApiController]
    [Route("[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IRepository<Announcement> _announcementRepository;

        public AnnouncementController(IRepository<Announcement> announcementRepository)
    {
        _announcementRepository = announcementRepository;
    }

        [HttpGet]
        public IEnumerable<Announcement> Get()
        {
           
        }
    }

