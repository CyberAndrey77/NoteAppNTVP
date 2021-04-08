using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Копия класса Note.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Поле для всплывающей подсказки в TextBox.
        /// </summary>
        //private ToolTip _nameNoteToolTipTextBox;

        /// <summary>
        /// Поле сохраняющее исключения вызваных в TextBox.
        /// </summary>
        private string _exceptionNoteNameTextBox;

        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = (Note)value.Clone();

                if (_note.Name == null)
                {
                    nameNoteTextBox.Text = "Untitled";
                    _note.Name = nameNoteTextBox.Text;
                    createdLabel.Text = DateTime.Today.ToLongDateString();
                    modifiedLabel.Text = DateTime.Today.ToLongDateString();
                }

                nameNoteTextBox.Text = _note.Name;
                noteTextRichTextBox.Text = _note.Text;
                categoryComboBox.SelectedItem = _note.Category;
                createdLabel.Text = _note.Created.ToLongDateString();
                modifiedLabel.Text = _note.Modified.ToLongDateString();
            }
        }

        public NoteForm()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            categoryComboBox.Items.AddRange(categories);

            SearchError();
        }

        /// <summary>
        /// Метод для поиска ошибок в полях для ввода данных.
        /// </summary>
        private void SearchError()
        {
            if (_exceptionNoteNameTextBox != null)
            {
                nameNoteToolTip.SetToolTip(nameNoteTextBox, _exceptionNoteNameTextBox);
                nameNoteTextBox.BackColor = Color.Red;
            }
            else
            {
                nameNoteTextBox.BackColor = Color.White;
                nameNoteToolTip.SetToolTip(nameNoteTextBox, "Enter the name of the note!");
            }
        }

        /// <summary>
        /// Событие вызывающееся при выборе категории заметок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _note.Category = (NoteCategory)categoryComboBox.SelectedItem;
        }

        /// <summary>
        /// Событие вызывающееся при изменени в поле TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Name = nameNoteTextBox.Text;
                _exceptionNoteNameTextBox = null;
            }
            catch (ArgumentException exception)
            {
                _exceptionNoteNameTextBox = exception.Message;
                
            }
            finally
            {
                SearchError();
            }
        }

        /// <summary>
        /// Событие вызывающееся при изменени в поле RichTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noteTextRichTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = noteTextRichTextBox.Text;
        }

        /// <summary>
        /// Событие вызывающееся при нажатии на кнопку OK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (_exceptionNoteNameTextBox == null)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show
            (
                _exceptionNoteNameTextBox,
                "Input errors",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}
