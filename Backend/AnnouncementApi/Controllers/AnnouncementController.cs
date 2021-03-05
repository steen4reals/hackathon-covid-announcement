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
        try{
        var returnedAnnouncement = await _announcementRepository.Get(id);
        
        return Ok(returnedAnnouncement);
        }
        catch (Exception){
        return BadRequest("Id not found");
        }
    }

    //Put{id} -> Update(announcement)
    [HttpPut("{id}")]

    public async Task<IActionResult> Update(long id, [FromBody] Announcement announcement)
    {
        try{
            var updatedAnnouncement = await _announcementRepository.Update(new Announcement {Id = id, Date = announcement.Date, Title = announcement.Title, Industry = announcement.Industry, Description = announcement.Description});

            return Ok(updatedAnnouncement);
        }
        catch(Exception){
            return BadRequest("Id not found");
        }
    }


    //Post -> Insert
    [HttpPost]
    public async Task<IActionResult> Insert([FromBody] Announcement announcement)
    {
        try 
        {
            var insertedAnnouncement = await _announcementRepository.Insert(announcement);
            return Created($"/announcements/{insertedAnnouncement.Id}", insertedAnnouncement);
        }
        catch(Exception)
        {
            return BadRequest("Announcement entered is not valid");
        }
    }

    //Delete{id} -> Delete
    [HttpDelete("{id}")]

    public IActionResult Delete(long id)
    {
        try
        {
            _announcementRepository.Delete(id);
            return Ok($"Announcement at {id} is deleted");
        }
        catch(Exception)
        {
            return BadRequest("Id is not valid");
        }
    }

}

