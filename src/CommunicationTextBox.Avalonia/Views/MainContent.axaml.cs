using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunicationTextBox.Common.ViewModels;

namespace CommunicationTextBox.Avalonia.Views;

public partial class MainContent : UserControl
{
    public MainContent()
    {
        InitializeComponent();
        this.DataContext = new MainContentViewModel();
    }
}