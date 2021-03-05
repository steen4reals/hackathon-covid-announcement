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

    //Get -> GetAll
    [HttpGet]
    public async Task<IActionResult> GetAll(string search = null)
    {

        if (search != null)
        {
            try
            {
                var searchResult = await _announcementRepository.Search(search);
                return Ok(searchResult);
            }
            catch (Exception)
            {
                return BadRequest("The text you've entered is invalid.");
            }
        }

        try
        {
            var allAnnouncements = await _announcementRepository.GetAll();
            return Ok(allAnnouncements);
        }
        catch (Exception)
        {
            return NotFound("There are no announcements.");
        }

    }

    //Get{Id} -> Get(id)
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var returnedAnnouncement = await _announcementRepository.Get(id);
        Ok(returnedAnnouncement);
    }


    //Put{id} -> Update(announcement)

    //Post -> Insert

    //Delete{id} -> Delete
}

