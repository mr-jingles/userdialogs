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
        
        public ConflictDialog()
        {
            
            InitializeComponent();

            /*
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
            */
        }

        private void LoadDesignTimeData()
        {
            /*
            ConflictTable.ItemsSource = new MvxObservableCollection<ReadOnlyDocument>()
            {
               
            };*/
        }

        /* EP use Command binding
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

        
    }

  
}
