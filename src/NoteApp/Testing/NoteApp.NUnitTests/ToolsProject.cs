using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.NUnitTests
{
    public static class ToolsProject
    {
        public static Project CreateNotes()
        {
            var project = new Project();
            var note = new Note(new DateTime(1990, 05, 10))
            {
                Name = "Name1",
                Category = NoteCategory.Documents,
                Text = "Same text1",
                Modified = new DateTime(1990, 05, 10)
            };
            project.Notes.Add(note);
            note = new Note(new DateTime(1995, 05, 10))
            {
                Name = "Name2",
                Category = NoteCategory.Finance,
                Text = "Same text2",
                Modified = new DateTime(1995, 05, 10)
            };
            project.Notes.Add(note);
            note = new Note(new DateTime(2000, 05, 10))
            {
                Name = "Name3",
                Category = NoteCategory.Various,
                Text = "Same text3",
                Modified = new DateTime(2000, 05, 10)
            };
            project.Notes.Add(note);
            note = new Note(new DateTime(2005, 05, 10))
            {
                Name = "Name4",
                Category = NoteCategory.HealthAndSport,
                Text = "Same text4",
                Modified = new DateTime(2005, 05, 10)
            };
            project.Notes.Add(note);
            note = new Note(new DateTime(2010, 05, 10))
            {
                Name = "Name5",
                Category = NoteCategory.Work,
                Text = "Same text5",
                Modified = new DateTime(2010, 05, 10)
            };
            project.Notes.Add(note);
            note = new Note(new DateTime(2015, 05, 10))
            {
                Name = "Name6",
                Category = NoteCategory.Work,
                Text = "Same text6",
                Modified = new DateTime(2015, 05, 10)
            };
            project.Notes.Add(note);
            note = new Note(new DateTime(2020, 05, 10))
            {
                Name = "Name7",
                Category = NoteCategory.Work,
                Text = "Same text7",
                Modified = new DateTime(2020, 05, 10)
            };
            project.Notes.Add(note);
            project.SelectedNoteIndex = 0;
            return project;
        }
    }
}
