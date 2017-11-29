using System;
using System.Collections.Generic;
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

namespace Acr.UserDialogs
{
    /// <summary>
    /// Interaktionslogik für InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window, IDisposable
    {

        #region Properties

        /// <summary>
        /// Gets or sets the text that was entered by the user
        /// </summary>
        public string Text
        {
            get
            {
                return IsPassword ? _passwordBox.Password : _inputBox.Text;
            }
            set
            {
                if (IsPassword)
                {
                    _passwordBox.Password = value;
                }
                else
                {
                    _inputBox.Text = value;
                }
            }
        }

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
        }

        /// <summary>
        /// Gets or sets whether or not the input should be masked from the user
        /// </summary>
        public bool IsPassword
        {
            get
            {
                return _passwordBox.Visibility == Visibility.Visible;
            }
            set
            {
                _passwordBox.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
                _inputBox.Visibility = value ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        /// <summary>
        /// Gets whether or not the OK button was pressed
        /// </summary>
        public bool WasOk
        {
            get; private set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public InputDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region Private API

        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            WasOk = !((Button)sender).IsCancel;
            Close();
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            // No-op, needed for IUserDialogs
        }

        #endregion

    }
}
