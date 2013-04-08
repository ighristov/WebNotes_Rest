using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebNotes_Rest;
using WebNotes_Rest.Controllers;
using oaWebNotes;

namespace WebNotes_Rest.Tests.Controllers
{
    [TestClass]
    public class NotesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            NotesController controller = new NotesController();

            // Act
            IEnumerable<Note> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count());
        }

        private Note GetLastNote(NotesController controller)
        {
            return controller.Get().OrderBy(n => n.FID).LastOrDefault();
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            NotesController controller = new NotesController();

            Note _lastNote = GetLastNote(controller);
            Assert.IsNotNull(_lastNote);

            // Act
            Note resultNote = controller.Get(_lastNote.FID);

            // Assert
            Assert.AreEqual(resultNote.FID, _lastNote.FID);
            Assert.AreEqual(resultNote.FCONTENT, _lastNote.FCONTENT);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            NotesController controller = new NotesController();
            
            // Act
            Note _postedNote = new Note() {FTITLE = "testNoteTitle", FCONTENT = "testNoteContent", FCATEGORY_ID = 1, FTIMESTAMP = DateTime.Now.Ticks};
            controller.Post(_postedNote); //it should be the last note because of autoincrement FID.
            Note _lastNote = GetLastNote(controller);

            // Assert
            Assert.AreEqual(_postedNote.FID, _lastNote.FID);
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            NotesController controller = new NotesController();

            // Act
            Note _note = GetLastNote(controller);
            _note.FTITLE = "TestChangedTitle";
            controller.Put(_note.FID, _note);

            Note _lastNote = GetLastNote(controller);
            // Assert
            Assert.AreEqual(_note.FTITLE, _lastNote.FTITLE);
        }
    }
}
