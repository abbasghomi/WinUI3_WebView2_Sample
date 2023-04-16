using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using WinUI3_WebView2_Sample.Models;
using WinUI3_WebView2_Sample.ViewModels.Base;

namespace WinUI3_WebView2_Sample.ViewModels
{
    public partial class ListPage3ViewModel : ViewModelBase
    {
        public ContentListItem SelectedListItem
        {
            get => _selectedListItem;
            set
            {
                _selectedListItem = value;

                PreviewContent = value.WebContent;

            }
        }


        private ContentListItem _selectedListItem;

        [ObservableProperty] private string _previewContent;

        [ObservableProperty]
        private List<ContentListItem> _items = new()
            {
                new ContentListItem() { WebDescription = "Sample 1", WebContent = "<!DOCTYPE html><html><head><title>My Seventh Webpage</title></head><body><h1>My to-do list</h1><ul><li>Buy groceries</li><li>Do laundry</li><li>Pay bills</li></ul></body></html>" },
                new ContentListItem() { WebDescription = "Sample 2", WebContent = "<!DOCTYPE html><html><head><title>My Sixth Webpage</title></head><body><h1>Check out this video</h1><video controls><source src=\"myvideo.mp4\" type=\"video/mp4\">Your browser does not support the video tag.</video></body></html>"},
                new ContentListItem() { WebDescription = "Sample 3", WebContent = "<!DOCTYPE html><html><head><title>My Fifth Webpage</title></head><body><h1>Contact me</h1><form><label for=\"name\">Name:</label><input type=\"text\" id=\"name\" name=\"name\"><br><br><label for=\"email\">Email:</label><input type=\"email\" id=\"email\" name=\"email\"><br><br><label for=\"message\">Message:</label><textarea id=\"message\" name=\"message\"></textarea><br><br><input type=\"submit\" value=\"Submit\"></form></body></html>"},
                new ContentListItem() { WebDescription = "Sample 4", WebContent = "<!DOCTYPE html><html><head><title>My Fourth Webpage</title></head><body><h1>My favorite foods</h1><table><tr><th>Food</th><th>Ranking</th></tr><tr><td>Pizza</td><td>1</td></tr><tr><td>Tacos</td><td>2</td></tr><tr><td>Sushi</td><td>3</td></tr></table></body></html>"},
                new ContentListItem() { WebDescription = "Sample 5", WebContent = "<!DOCTYPE html><html><head><title>My Third Webpage</title></head><body><h1>Check out this link</h1><p>Click <a href=\"https://www.google.com/\">here</a> to go to Google.</p></body></html>"},
                new ContentListItem() { WebDescription = "Sample 6", WebContent = "<!DOCTYPE html><html><head><title>My Second Webpage</title></head><body><h1>Check out this cool image</h1><img src=\"myimage.jpg\" alt=\"A cool image\"></body></html>"},
                new ContentListItem() { WebDescription = "Instagram", WebContent = "<!DOCTYPE html><html><head><title>My First Webpage</title></head><body><h1>Welcome to my webpage</h1><p>This is my first webpage. Here's some text to fill up the page.</p></body></html>"},
            };
    }

}
