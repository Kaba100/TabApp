using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabApp.Models;

namespace TabApp.ViewModel
{
  public partial class FriendViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Friend> friends;

        public FriendViewModel()
        {
            Friends = new ObservableCollection<Friend>();
            Friends.Add(new Friend
            {
                Name = "Taiwo",
                Picture = "modiba.jpg",
                Message = "Hello,how are you doing?",
                LastChatTime = "7:45pm"
            });
            Friends.Add(new Friend
            {
                Name = "Kehinde",
                Picture = "modiba.jpg",
                Message = "Hello,how are you doing?",
                LastChatTime = "7:45pm"
            });
            Friends.Add(new Friend
            {
                Name = "Idowu",
                Picture = "modiba.jpg",
                Message = "Hello,how are you doing?",
                LastChatTime = "Yesterday"
            });
            Friends.Add(new Friend
            {
                Name = "Hadizah Abdullah",
                Picture = "modiba.jpg",
                Message = "Hello,good evening?",
                LastChatTime = "12:00am"
            });
            Friends.Add(new Friend
            {
                Name = "Hadja Fanta",
                Picture = "modiba.jpg",
                Message = "Hello,can I tell you something?",
                LastChatTime = "Last Month"
            });
        }
    }
}
