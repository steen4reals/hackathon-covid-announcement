using System;
using Xunit;
using NSubstitute;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;

namespace AnnouncementApi.UnitTests
{
  public class AnnouncementControllerTest
  {
    //fields
    readonly AnnouncementController _controller;
    readonly List<Announcement> _announcements;

    //constructor
    public AnnouncementControllerTest()
    {
      //arrange
      _announcements = new List<Announcement> {
        new Announcement
        {
          Date = new DateTime(2020, 5, 1, 8, 30, 52),
          Description = "Not a real description.",
          Id = 14,
          Industry = "Testing",
          Title = "Stage 3"
        },
        new Announcement
        {
          Date = new DateTime(2021, 5, 1, 8, 30, 52),
          Description = "Testing",
          Id = 12,
          Industry = "Ceremonies",
          Title = "Stage 2"
        },
        new Announcement
        {
          Date = new DateTime(2020, 5, 1, 8, 30, 52),
          Description = "Testing again. Not a real description.",
          Id = 1,
          Industry = "Ceremonies",
          Title = "Stage 1"
        }
      };

      var announcementRepository = Substitute.For<IRepository<Announcement>>();
      announcementRepository.GetAll().Returns(x => _announcements);
      _controller = new AnnouncementController(announcementRepository);
    }

    [Fact]
    public async Task GetAll_WhenCalledWithNothingPassedIn_ReturnStatusCode200()
    {
      //act
      var result = await _controller.GetAll();
      var statusCode = ((OkObjectResult)result).StatusCode;
      //assert
      statusCode.Should().Be(200);
    }

    [Fact]
    public async Task GetAll_WhenCalledWithNothingPassedIn_ReturnsAllAnnouncements()
    {
      //act
      var result = await _controller.GetAll();
      var announcements = ((OkObjectResult)result).Value as List<Announcement>;
      //assert
      announcements.Should().BeEquivalentTo(_announcements);
    }


    [Fact]
    public void Delete_WhenCalledWithId_ReturnStatusCode200()
    {
      //act
      var statusCode = ((OkObjectResult)_controller.Delete(2)).StatusCode;
      //assert
      statusCode.Should().Be(200);
    }


  }
}
