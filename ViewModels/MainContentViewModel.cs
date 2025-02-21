using CommunicationTextbox.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CommunicationTextbox.ViewModels;

public partial class MainContentViewModel : ObservableObject
{
    [ObservableProperty] ObservableCollection<MessageModel> _messages;

    public MainContentViewModel()
    {
        this.Messages = new ObservableCollection<MessageModel> ();


        /*TestCode*/
        this.Messages.Add (new MyMessageModel ()
        {
            Message = "Hello, World",
            ArriveTime = DateTime.Now,
        });

        this.Messages.Add (new YouMessageModel ()
        {
            Id ="World",
            Message = "Hello",
            ArriveTime = DateTime.Now,
        });

        this.Messages.Add (new MyMessageModel ()
        {
            Message = "뭐해?",
            ArriveTime = DateTime.Now,
        });
    }
}

