using System.IO;
using System.Windows;
using GitProcess.Entities;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace GitProcess
{
    public partial class MainWindow : Window
    {
        private ToolBoxConfiguration _toolBoxConfiguration;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnToolBoxImport(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { DefaultExt = ".json", CheckFileExists = true, Filter = "Toolboxes (*.json)|*.json" };
            bool? hasSelectedAFile = openFileDialog.ShowDialog();
            if(hasSelectedAFile.HasValue && hasSelectedAFile.Value)
            {
                _toolBoxConfiguration = JsonConvert.DeserializeObject<ToolBoxConfiguration>(File.ReadAllText(openFileDialog.FileName));
                Processus.ItemsSource = _toolBoxConfiguration.Tasks;
            }
        }

        private void OnNewTaskAdded(object sender, System.Windows.Controls.AddingNewItemEventArgs e)
        {
            System.Console.WriteLine();
        }
    }
}
