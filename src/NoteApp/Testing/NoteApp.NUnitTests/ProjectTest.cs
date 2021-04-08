using System;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace NoteApp.NUnitTests
{
    [TestFixture]
    class ProjectTest
    {
        [Test(Description = "Test Note designer")]
        public void TestDesigner()
        {
            var project = new Project();
        }

        [Test(Description = "Test method SortProjectByModified")]
        public void TestSortProjectByModified()
        {
            //Setup
            var project = ToolsProject.CreateNotes();
            project.Notes = Project.SortProjectByModified(project.Notes);
            bool isSorting = true;

            //Act
            for (int i = 1; i < project.Notes.Count; i++)
            {
                if (project.Notes[i].Modified.CompareTo(project.Notes[i - 1].Modified) > 0)
                {
                    isSorting = false;
                    break;
                }
            }

            //Assert
            Assert.AreEqual(isSorting, true, "Sort list incorrect");
        }

        [Test(Description = "Test method FilterProjectByCategory")]
        public void TestFilterProjectByCategory()
        {
            //Setup
            var project = ToolsProject.CreateNotes();
            project.Notes = Project.FilterProjectByCategory(project.Notes, NoteCategory.Work);
            bool isFiltring = true;

            //Act
            for (int i = 1; i < project.Notes.Count; i++)
            {
                if (project.Notes[i].Category != project.Notes[i - 1].Category)
                {
                    isFiltring = false;
                    break;
                }
            }

            //Assert
            Assert.AreEqual(isFiltring, true, "Filter list incorrect");
        }

        [Test(Description = "Positive test getter and setter SelectedNoteIndex")]
        public void TestSelectedNoteIndexGet_CorrectValue()
        {
            //Setup
            var project = new Project();
            var expected = 1;
            project.SelectedNoteIndex = expected;

            //Act
            var actual = project.SelectedNoteIndex;

            //Assert
            Assert.AreEqual(expected, actual, "Getter returned an invalid value");
        }
    }
}