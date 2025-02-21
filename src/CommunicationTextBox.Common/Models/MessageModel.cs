namespace CommunicationTextBox.Common.Models;

public class MessageModel
{
    public string Message { get; set; }
    public DateTime ArriveTime { get; set; }
}

public class MyMessageModel : MessageModel
{

}   

public class YouMessageModel : MessageModel
{
    public string Id { get; set; }
}

