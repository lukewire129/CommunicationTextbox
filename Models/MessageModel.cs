using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CommunicationTextbox.Models;

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
    public Image Image { get; set; }
}

