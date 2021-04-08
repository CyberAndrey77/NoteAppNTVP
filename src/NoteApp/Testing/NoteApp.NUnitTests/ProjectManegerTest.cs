using System;
using System.IO;
using System.Threading;
using NUnit.Framework;

namespace NoteApp.NUnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        private readonly string _pathTestData = "TestData\\";
        private string _pathOutput = "Output\\";

        private string _fileName = "correctprojectfile.json";
        private string _fileNameBroken = "incorrectprojectfile.json";

        

        [Test(Description = "Test Note designer")]
        public void TestDesigner()
        {
            //Act
            var project = new Project();
        }

        [Test(Description = "Positive test SaveFile")]
        public void SaveFile_ResultCorrectValue()
        {
            //Setup
            var project = ToolsProject.CreateNotes();
            var expected = File.ReadAllText(_pathTestData + _fileName);
            
            //Act
            ProjectManager.SaveFile(project, _pathOutput + _fileName);

            ////Assert
            var actual = File.ReadAllText(_pathOutput + _fileName);
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Positive test LoadFile")]
        public void LoadFile_ResultCorrectValue()
        {
            //Setup
            var expectedProject = ToolsProject.CreateNotes();
            
            //Act
            var actualProject = ProjectManager.LoadFile(_pathTestData + _fileName);

            //Assert
            Assert.AreEqual(actualProject.Notes.Count, expectedProject.Notes.Count);
            Assert.Multiple(() =>
            {
                for (int i = 0; i < expectedProject.Notes.Count; i++)
                {
                    var expected = expectedProject.Notes[i];
                    var actual = actualProject.Notes[i];
                    Assert.AreEqual(expected, actual);
                }
            });
        }

        [Test(Description = "Negative test LoadFile")]
        public void TestLoadFile_ResultIncorrectValue()
        {
            //Setup
            var expectedpProject = new Project();

            //Act
            var actualProject = ProjectManager.LoadFile(_pathTestData + _fileNameBroken);

            //Assert
            Assert.AreEqual(expectedpProject.Notes.Count, actualProject.Notes.Count, "File load incorrectly");
        }
    }
}
