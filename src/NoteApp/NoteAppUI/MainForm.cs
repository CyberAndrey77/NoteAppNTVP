using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Класс содержащий список классов Note.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Отсфильтрованый список заметок.
        /// </summary>
        private List<Note> _filtredNotes = new List<Note>();

        /// <summary>
        /// Путь до файла с сохраненими.
        /// </summary>
        private string _path = ProjectManager.DefaultPath + ProjectManager.FileName;
        public MainForm()
        {
            InitializeComponent();
            _project = new Project();

            _project = ProjectManager.LoadFile(_path);
            _project.Notes = Project.SortProjectByModified(_project.Notes);

            categoryComboBox.Items.Add("All");

            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            categoryComboBox.Items.AddRange(categories);
            categoryComboBox.SelectedIndex = 0;

            if (notesListBox.Items.Count != 0)
            {
                notesListBox.SelectedIndex = _project.SelectedNoteIndex;
            }
        }

        /// <summary>
        /// Метод для создания заметки.
        /// </summary>
        private void CreateNote()
        {
            var note = new Note();
            var noteForm = new NoteForm
            {
                Note = note
            };
            if (noteForm.ShowDialog() == DialogResult.OK)
            {
                note = noteForm.Note;
                if (categoryComboBox.SelectedItem.ToString() == "All")
                {
                    _filtredNotes.Insert(0, noteForm.Note);
                    notesListBox.Items.Insert(0, _project.Notes[0].Name);
                }
                else
                {
                    if (noteForm.Note.Category == (NoteCategory)categoryComboBox.SelectedItem)
                    {
                        _filtredNotes.Insert(0, noteForm.Note);
                        notesListBox.Items.Insert(0, _project.Notes[0].Name);
                    }
                }
                if (_filtredNotes != _project.Notes)
                {
                    _project.Notes.Insert(0, note);
                }
                if (notesListBox.Items.Count == 0)
                {
                    categoryComboBox.SelectedIndex = 0;
                }
                UpdateRightPanel(_project.Notes, 0);
            }

            _project.Notes = Project.SortProjectByModified(_project.Notes);
            ProjectManager.SaveFile(_project, _path);
        }

        /// <summary>
        /// Метод для редактирования заметки.
        /// </summary>
        private void EditNote()
        {
            if (notesListBox.SelectedItem == null)
            {
                MessageBox.Show
                (
                    "Choose a note!",
                    "Input errors",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var noteForm = new NoteForm
            {
                Note = _filtredNotes[notesListBox.SelectedIndex]
            };
            if (noteForm.ShowDialog() == DialogResult.OK)
            {
                if (_filtredNotes != _project.Notes)
                {
                    var index = _project.Notes.IndexOf(_filtredNotes[notesListBox.SelectedIndex]);
                    _project.Notes.RemoveAt(index);
                    _project.Notes.Insert(0, noteForm.Note);
                }
                _filtredNotes.RemoveAt(notesListBox.SelectedIndex);
                notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);

                if (categoryComboBox.SelectedItem.ToString() == "All")
                {
                    _filtredNotes.Insert(0, noteForm.Note);
                    notesListBox.Items.Insert(0, _project.Notes[0].Name);
                }
                else
                {
                    if (noteForm.Note.Category == (NoteCategory)categoryComboBox.SelectedItem)
                    {
                        _filtredNotes.Insert(0, noteForm.Note);
                        notesListBox.Items.Insert(0, _project.Notes[0].Name);
                    }
                }

                if (notesListBox.Items.Count == 0)
                {
                    categoryComboBox.SelectedIndex = 0;
                }

                
                UpdateRightPanel(_filtredNotes, 0);
                
            }
            _project.Notes = Project.SortProjectByModified(_project.Notes);
            ProjectManager.SaveFile(_project, _path);
        }

        /// <summary>
        /// Метод для удаления заметки.
        /// </summary>
        private void RemoveNote()
        {
            if (notesListBox.SelectedItem == null)
            {
                MessageBox.Show
                (
                    "Choose a note!",
                    "Input errors",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult dialog = MessageBox.Show
            (
                "Do you really want to remove a note?",
                "Remove a note",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialog != DialogResult.Yes)
            {
                return;
            }

            if (_filtredNotes != _project.Notes)
            {
                var index = _project.Notes.IndexOf(_filtredNotes[notesListBox.SelectedIndex]);
                _project.Notes.RemoveAt(index);
            }
            _filtredNotes.RemoveAt(notesListBox.SelectedIndex);

            notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);
            UpdateRightPanel(_filtredNotes, 0);

            if (notesListBox.Items.Count == 0)
            {
                categoryComboBox.SelectedIndex = 0;
            }

            _project.Notes = Project.SortProjectByModified(_project.Notes);
            ProjectManager.SaveFile(_project, _path);
        }

        /// <summary>
        /// Метод для редактиования правой панели.
        /// </summary>
        /// <param name="index">Индекс измененой заметки.</param>
        private void UpdateRightPanel(List<Note> note, int index)
        {
            if (notesListBox.Items.Count == 0)
            {
                ClearRightPanel();
                return;
            }
            nameNoteLabel.Text = note[index].Name;
            categorylabel.Text = note[index].Category.ToString();
            noteTextRichTextBox.Text = note[index].Text;
            createdLabel.Text = note[index].Created.ToLongDateString();
            modifiedLabel.Text = note[index].Modified.ToLongDateString();
        }

        /// <summary>
        /// Метод отчищающий правую панель.
        /// </summary>
        private void ClearRightPanel()
        {
            nameNoteLabel.Text = string.Empty;
            categorylabel.Text = string.Empty;
            noteTextRichTextBox.Text = string.Empty;
            createdLabel.Text = string.Empty;
            modifiedLabel.Text = string.Empty;
        }
        
        /// <summary>
        /// Метод позволюящий выйти из приложения через кнопу или сочетания клавиш Ait + F4
        /// </summary>
        private void Exit()
        {
            Application.Exit();
        }

        /// <summary>
        /// Событие создания окна About.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenu_Click(object sender, EventArgs e)
        {
            var formAbout = new AboutForm();
            formAbout.Show();
        }

        /// <summary>
        /// Событие вызывающее окно создание заметки Add/Edit Note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            CreateNote();
        }

        /// <summary>
        /// Событие вызывающее окно создание заметки Add/Edit Note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteButton_Click(object sender, EventArgs e)
        {
            CreateNote();
        }

        /// <summary>
        /// Событие вызывающееся при закрытии приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveFile(_project, _path);
            var dialog = MessageBox.Show
            (
                @"Do you really want to exit?",
                @"Program exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            e.Cancel = (dialog != DialogResult.Yes);
        }

        /// <summary>
        /// Событие вызывающееся при выборе элемента в списке ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notesListBox.SelectedItem == null)
            {
                return;
            }

            if (_filtredNotes.Count != 0)
            {
                UpdateRightPanel(_filtredNotes, notesListBox.SelectedIndex);
                int index = _project.Notes.IndexOf(_filtredNotes[notesListBox.SelectedIndex]);
                _project.SelectedNoteIndex = index;
            }
            else
            {
                UpdateRightPanel(_project.Notes, notesListBox.SelectedIndex);
                _project.SelectedNoteIndex = notesListBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Событие вызывающее окно создание заметки Add/Edit Note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Событие вызывающее окно создание заметки Add/Edit Note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Событие удаляющие заметку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Событие удаляющие заметку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Событие вызывающее закрытие приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            Exit();
        }

        /// <summary>
        /// Событие вызывающееся при выборе категории в ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            notesListBox.Items.Clear();

            if (categoryComboBox.SelectedItem.ToString() == "All")
            {

                _filtredNotes = _project.Notes;
            }
            else
            {
                _filtredNotes = Project.FilterProjectByCategory(_project.Notes,
                    (NoteCategory) categoryComboBox.SelectedItem);
            }

            foreach (var note in _filtredNotes)
            {
                notesListBox.Items.Add(note.Name);
            }
        }
    }
}
