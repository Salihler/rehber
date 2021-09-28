using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using rehber.Api.Controllers;
using rehber.Core.DTOs;
using rehber.Core.Models;
using rehber.Core.Services;
using Xunit;

namespace rehber.Test.Tests
{
    public class ContactControllerTest
    {
        ContactController _controller;
        IContactService _service;
        IMapper _mapper;

        public ContactControllerTest()
        {
            _service = new ServiceFake();
            _controller = new ContactController(_service, _mapper, null);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetAll();
            // Assert
            Assert.IsType<OkResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetAll().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<ContactDto>>(okResult.Value);
            Assert.Equal(25, items.Count);
        }
    }
}