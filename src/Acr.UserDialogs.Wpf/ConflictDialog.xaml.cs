using Couchbase.Lite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Data;
using System.Collections;
using System.Windows.Controls.Primitives;
using Acr.UserDialogs.Converter;

namespace Acr.UserDialogs
{
    /// <summary>
    /// Interaktionslogik für ConflictDialog.xaml
    /// </summary>
    public partial class ConflictDialog : Window, IDisposable
    {

        #region Properties

        /// <summary>
        /// Gets or sets the text for the confirmation button
        /// </summary>
        public string OkText
        {
            get
            {
                return _okButton.Content as string;
            }
            set
            {
                _okButton.Content = value;
            }
        }

        /// <summary>
        /// Gets whether or not the OK button was pressed
        /// </summary>
        public bool WasOk
        {
            get; private set;
        }

        public Conflict Conflict { get; set; }

        public Document _selectedDocument;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool _mineSelected;
        public bool MineSelected
        {
            get { return _mineSelected; }
            set
            {
                _mineSelected = value;
                _baseSelected = false;
                _theirsSelected = false;
                SelectedDocument = Conflict.Mine;
                NotifyPropertyChanged("BaseSelected");
                NotifyPropertyChanged("TheirsSelected");
                NotifyPropertyChanged("MineSelected");
            }
        }

        public bool _baseSelected;
        public bool BaseSelected
        {
            get { return _baseSelected; }
            set
            {
                _baseSelected = value;
                _mineSelected = false;
                _theirsSelected = false;
                SelectedDocument = Conflict.Base;
                NotifyPropertyChanged("BaseSelected");
                NotifyPropertyChanged("TheirsSelected");
                NotifyPropertyChanged("MineSelected");
            }
        }

        public bool _theirsSelected;
        public bool TheirsSelected
        {
            get { return _theirsSelected; }
            set
            {
                _theirsSelected = value;
                _baseSelected = false;
                _mineSelected = false;
                SelectedDocument = Conflict.Theirs;
                NotifyPropertyChanged("BaseSelected");
                NotifyPropertyChanged("TheirsSelected");
                NotifyPropertyChanged("MineSelected");
            }
        }

        public Document SelectedDocument
        {
            get
            {
                return _selectedDocument;
            }

            set
            {
                _selectedDocument = null;
                NotifyPropertyChanged("SelectedDocument");

                _selectedDocument = value;
                NotifyPropertyChanged("SelectedDocument");

            }
<<<<<<< HEAD
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
=======
            */
>>>>>>> refs/remotes/origin/master
        }

        #endregion

        public ConflictDialog(Conflict conflict)
        {
            InitializeComponent();
            this.DataContext = this;
            Conflict = conflict;
        }

<<<<<<< HEAD


=======
        /* EP use Command binding
>>>>>>> refs/remotes/origin/master
        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            WasOk = !((Button)sender).IsCancel;
            Close();
        }*/

        #region IDisposable

        public void Dispose()
        {
            // No-op, needed for IUserDialogs
        }

        #endregion

<<<<<<< HEAD

=======

>>>>>>> refs/remotes/origin/master
    }


}
