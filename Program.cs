using System;
using System.IO;
using System.Windows.Forms;

ApplicationConfiguration.Initialize();

Button selectFilesButton = new()
{
    Text = "Select GBX File(s)",
};

OpenFileDialog openFileDialog = new()
{
    Filter = "GBX Files (*.gbx)|*.gbx",
    Multiselect = true,
    ShowHelp = true,
    InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Trackmania", "Maps")
};

selectFilesButton.Click += (_, _) => 
{
    if  (openFileDialog.ShowDialog() == DialogResult.OK)
    {
        string[] selectedFiles = openFileDialog.FileNames;
        selectFilesButton.Text = $"Selected {selectedFiles.Length} file(s)";
    }
};

Form form = new()
{
    Text = "Altered Nadeo Tool",
    Controls =
    {
        selectFilesButton   
    }
};

Application.Run(form);