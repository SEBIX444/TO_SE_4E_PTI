using System.Collections.ObjectModel;

namespace NotatkiMobilne;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Notes { get; } =
        new ObservableCollection<string>
        {
            "Nauczyć się Młodej Polski na Sprawdzian",
            "Kupić twaróg, mąke, cebule na pierogi",
            "Ugotować pierogi ruskie"
        };

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnAddButtonClicked(object? sender, EventArgs e)
    {
        string note = NoteEntry.Text?.Trim() ?? string.Empty;

        if (!string.IsNullOrWhiteSpace(note))
        {
            Notes.Add(note);
            NoteEntry.Text = string.Empty;
        }
    }
}
