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
    public partial class ConflictDialogBak : Window, IDisposable, INotifyPropertyChanged
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
        /// Gets or sets the text for the cancellation button
        /// </summary>
        /*
        public string CancelText
        {
            get
            {
                return _cancelButton.Content as string;
            }
            set
            {
                _cancelButton.Content = value;
            }
        }*/

        /// <summary>
        /// Gets whether or not the OK button was pressed
        /// </summary>
        public bool WasOk
        {
            get; private set;
        }

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

        public ConflictDialogBak(Conflict conflict)
        {
            InitializeComponent();
            this.DataContext = this;

            if (conflict.Base != null)
            {
                BaseTable.Columns.Add(new DataGridTextColumn());

                DataGridTextColumn column;
                foreach (var item in conflict.Base.Keys)
                {
                    column = new DataGridTextColumn();
                    column.Header = item;
                    column.Binding = new Binding("[" + item + "]");
                    BaseTable.Columns.Add(column);
                }
            }

            Base.Add(conflict.Base);


            if (conflict.Theirs != null)
            {
                TheirsTable.Columns.Add(new DataGridTextColumn());

                DataGridTextColumn column;
                foreach (var item in conflict.Theirs.Keys)
                {
                    column = new DataGridTextColumn();
                    column.Header = item;
                    column.Binding = new Binding("[" + item + "]");
                    TheirsTable.Columns.Add(column);
                }
            }

            Theirs.Add(conflict.Theirs);

            if (conflict.Mine != null)
            {
                MineTable.Columns.Add(new DataGridTextColumn());

                DataGridTextColumn column;
                foreach (var item in conflict.Mine.Keys)
                {
                    column = new DataGridTextColumn();
                    column.Header = item;
                    column.Binding = new Binding("[" + item + "]");
                    MineTable.Columns.Add(column);
                }
            }
            LocalVersion.Add(conflict.Mine);

            if (DesignerProperties.GetIsInDesignMode(this))
            {
                LoadDesignTimeData();

            }
        }

        public static IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        {
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }

        private void LoadDesignTimeData()
        {
            /*
            ConflictTable.ItemsSource = new MvxObservableCollection<ReadOnlyDocument>()
            {

            };*/
        }

        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            WasOk = !((Button)sender).IsCancel;
            Close();
        }

        #region IDisposable

        public void Dispose()
        {
            // No-op, needed for IUserDialogs
        }

        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                /// your code here...
                throw new ApplicationException();
                /// your code here...
            }
            catch (Exception ex)
            {
                if (IntPtr.Size == 8)   // 64bit machines are unable to properly throw the errors during a Page_Loaded event.
                {
                    BackgroundWorker loaderExceptionWorker = new BackgroundWorker();
                    loaderExceptionWorker.DoWork += ((exceptionWorkerSender, runWorkerCompletedEventArgs) => { runWorkerCompletedEventArgs.Result = runWorkerCompletedEventArgs.Argument; });
                    loaderExceptionWorker.RunWorkerCompleted += ((exceptionWorkerSender, runWorkerCompletedEventArgs) => { throw (Exception)runWorkerCompletedEventArgs.Result; });
                    loaderExceptionWorker.RunWorkerAsync(ex);
                }
                else
                    throw;
            }
        }
    }


}
