using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using IOExtensions;
using System.IO;
using System.Threading;

// Task - Create Multithreading file copy application

namespace Multithreading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // add cancellation token
        CancellationTokenSource cancellation;
        public string? PathFrom { get; set; }
        public string? PathTo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FromBrowseClicked(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                PathFrom = dialog.FileName;
                fromTxtBox.Text = PathFrom;
            }
        }

        private void ToBrowseClicked(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                PathTo = dialog.FileName;
                toTxtBox.Text = PathTo;
            }
        }

        private void CopyBtnClicked(object sender, RoutedEventArgs e)
        {
            cancellation = new CancellationTokenSource();

            if (string.IsNullOrEmpty(PathFrom) || string.IsNullOrEmpty(PathTo))
            {
                MessageBox.Show("Choose a source and destination path!", "Can not process copy.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string fileName = Path.GetFileName(PathFrom);
            string dest = Path.Combine(PathTo, fileName);

            // check if destination and file source are distinct
            if (dest != PathFrom)
            {
                Task.Run(() =>
                {
                    FileCopy(PathFrom, dest);
                });
            }
            else
            {
                MessageBox.Show("File paths are the same!", "Can not process copy.", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void FileCopy(string source, string destination)
        {
            FileTransferManager.CopyWithProgress(source, destination, (obj) =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    // provide speed
                    speedLabel.Content = obj.BytesPerSecond;
                    // provide percentage
                    progressBar.Value = obj.Percentage;
                    progressLabel.Content = obj.Percentage;
                    // provide bytes copied
                    bytesLabel.Content = obj.BytesTransferred;

                });
            }, false);

            MessageBox.Show("Complete!");
        }

        // cancel copy
        private void CancelCopyClickBtn(object sender, RoutedEventArgs e)
        {
            cancellation?.Cancel();
            this.Close();
        }
    }
}
