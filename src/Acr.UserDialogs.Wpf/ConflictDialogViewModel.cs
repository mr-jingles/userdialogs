using Couchbase.Lite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Acr.UserDialogs
{
    public class ConflictDialogViewModel
    {
        public ICommand SubmitConflictCommand { get; set; }

        #region Properties
        /// <summary>
        /// Gets or sets the text for the confirmation button
        /// </summary>
        public string OkText { get; set; }

        /// <summary>
        /// Gets whether or not the OK button was pressed
        /// </summary>
        public bool WasOk { get; private set; }

        public List<Document> Base { get; set; } = new List<Document>();
        public List<Document> Theirs { get; set; } = new List<Document>();
        public List<Document> LocalVersion { get; set; } = new List<Document>();
        public Document _selectedConflict;
        public event PropertyChangedEventHandler PropertyChanged;
        public Document SelectedConflict
        {
            get
            {
                return _selectedConflict;
            }

            set
            {
                _selectedConflict = null;
                NotifyPropertyChanged("SelectedConflict");
                _selectedConflict = value;
                NotifyPropertyChanged("SelectedConflict");
            }
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion

    }
}
