using NUnit.Framework;
using System;

namespace NoteApp.NUnitTests
{
    [TestFixture]
    public class NoteTest
    {
        /// <summary>
        /// Допустимая разница во времени. Милисекундыю
        /// </summary>
        private const int ExpectedDifferenceTime = 10;

        /// <summary>
        /// Действительная разница во времени. Милисекунды.
        /// </summary>
        private int _actualDifferenceTime;

        [Test(Description = "Test designer Note")]
        public void TestDesigner()
        {
            //Setup
            var note = new Note();
            var expectedCreated = DateTime.Now;
            var expectedModified = DateTime.Now;

            //Act
            var actualCreated = note.Created;
            var actualModified = note.Modified;

            //Assert
            _actualDifferenceTime = (actualModified - expectedModified).Milliseconds;
            if (_actualDifferenceTime > ExpectedDifferenceTime)
            {
                Assert.Fail();
            }
            _actualDifferenceTime = (actualCreated - expectedCreated).Milliseconds;
            if (_actualDifferenceTime > ExpectedDifferenceTime)
            {
                Assert.Fail();
            }
        }

        [TestCase("", "An exception should occur if the name is an empty string", TestName = "Naming an empty string")]
        [TestCase("LongLongLongLongLongLongLongLongLongLongLongLongName",
            "An exception should occur if the name is longer than 50 symbols",
            TestName = "Assigning a name with more than 50 symbols")]
        public void NameSet_ArgumentException(string wrongName, string message)
        {
            //Setup
            var note = new Note();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                     //Act
                     note.Name = wrongName;
                 },
                message);

        }

        [Test(Description = "Positive test getter and setter Name")]
        public void Name_CorrectValue_ResultCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = "TestName";
            note.Name = expected;

            //Act
            var actual = note.Name;

            //Assert
            Assert.AreEqual(expected, actual, "Getter returned an invalid value");
        }

        [Test(Description = "Positive test getter and setter Category")]
        public void Category_CorrectValue_ResultCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = NoteCategory.Finance;
            note.Category = expected;

            //Act
            var actual = note.Category;

            //Assert
            Assert.AreEqual(expected, actual, "Getter returned an invalid value");
        }

        [Test(Description = "Positive test getter and setter Text")]
        public void Text_CorrectValue_ResultCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = "Some text \n some text on next line ";
            note.Text = expected;

            //Act
            var actual = note.Text;

            //Assert
            Assert.AreEqual(expected, actual, "Getter returned an invalid value");
        }

        [Test(Description = "Positive test getter and setter Modified")]
        public void Modified_CorrectValue_ResultCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = DateTime.Now;
            note.Modified = expected;

            //Act
            var actual = note.Modified;

            //Assert
            _actualDifferenceTime = (expected - actual).Milliseconds;
            if (_actualDifferenceTime > ExpectedDifferenceTime)
            {
                Assert.Fail();
            }
        }

        [Test(Description = "Positive test getter Modified, when change Name")]
        public void ModifiedGet_CorrectName_ResultCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = DateTime.Now;
            note.Name = "TestName";

            //Act
            var actual = note.Modified;

            //Assert
            _actualDifferenceTime = (expected - actual).Milliseconds;
            if (_actualDifferenceTime > ExpectedDifferenceTime)
            {
                Assert.Fail();
            }
        }

        [Test(Description = "Positive test getter Modified, when change Category")]
        public void TestModifiedGet_CorrectCategory_ResultCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = DateTime.Now;
            note.Category = NoteCategory.Documents;

            //Act
            var actual = note.Modified;

            //Assert
            _actualDifferenceTime = (expected - actual).Milliseconds;
            if (_actualDifferenceTime > ExpectedDifferenceTime)
            {
                Assert.Fail();
            }
        }

        [Test(Description = "Positive test getter Modified, when change Text")]
        public void TestModifiedGet_CorrectText_ResultCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = DateTime.Now;
            note.Text = "Text \n Text on next line";

            //Act
            var actual = note.Modified;

            //Setup
            _actualDifferenceTime = (expected - actual).Milliseconds;
            if (_actualDifferenceTime > ExpectedDifferenceTime)
            {
                Assert.Fail();
            }
        }

        [Test(Description = "Positive test for method Clone")]
        public void Clone()
        {
            //Setup
            var note = new Note();
            note.Name = "TestName";
            note.Category = NoteCategory.Documents;
            note.Text = "Text";

            //Act
            var noteClone = (Note)note.Clone();

            //Assert
            Assert.AreEqual(note, noteClone);
        }
    }
}