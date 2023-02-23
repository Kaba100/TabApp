using System.Collections.ObjectModel;
using TabApp.Models;
using TabApp.ViewModel;

namespace TabApp.Pages;

public partial class ChatPage : ContentPage
{
    //declaration
	
	public ChatPage()
	{
		InitializeComponent();

        //telling the xaml to look at this clss for its data
		BindingContext = new FriendViewModel();

        //created the instance of te collection
		

        //initialized the collection here with some sample friends objects
		
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        //  DisplayAlert("Good","This is what in the middle of the alert","Cancel");
        Shell.Current.GoToAsync("MessagePage");
    }
}