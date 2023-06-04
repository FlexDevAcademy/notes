using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using notes.Controllers;
using notes.Models;
using notes.Services;
using NSubstitute;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notes.Test
{
    public class NotebookControllerTests
    {

        private INoteService _noteService = Substitute.For<INoteService>();


        [Test]

        public async Task TestIndexViewData()
        {
            //arrange

            var controller = new NotebookController(_noteService);


            var notes = new Note[]
            {
                new Note { Id = 1, Title = "First Note", Description = "First Description", Created = DateTime.Now, DateOfEdition = DateTime.Now },

                new Note { Id = 2, Title = "First Note", Description = "First Description", Created = DateTime.Now, DateOfEdition = DateTime.Now },
            };

            _noteService.GetAll().Returns(notes);

            //Act

            var result = await controller.Index() as ViewResult;


            // Assert
            Assert.AreEqual(result.Model, notes);


        }
    }
}
