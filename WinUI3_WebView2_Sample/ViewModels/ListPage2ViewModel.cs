using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using WinUI3_WebView2_Sample.Models;
using WinUI3_WebView2_Sample.ViewModels.Base;

namespace WinUI3_WebView2_Sample.ViewModels
{
    public partial class ListPage2ViewModel : ViewModelBase
    {
        public ListItem SelectedListItem
        {
            get => _selectedListItem;
            set
            {
                _selectedListItem = value;

                PreviewContent = value.WebUrl;
            }
        }


        private ListItem _selectedListItem;

        [ObservableProperty] private string _previewContent;

        [ObservableProperty]
        private List<ListItem> _items = new()
            {
                new ListItem() { WebDescription = "Microsoft", WebUrl = "https://www.microsoft.com" },
                new ListItem() { WebDescription = "GitHub", WebUrl = "https://www.github.com"},
                new ListItem() { WebDescription = "Stack Overflow", WebUrl = "https://www.stackoverflow.com"},
                new ListItem() { WebDescription = "YouTube", WebUrl = "https://www.youtube.com"},
                new ListItem() { WebDescription = "Twitter", WebUrl = "https://www.twitter.com"},
                new ListItem() { WebDescription = "Facebook", WebUrl = "https://www.facebook.com"},
                new ListItem() { WebDescription = "Instagram", WebUrl = "https://www.instagram.com"},
                new ListItem() { WebDescription = "LinkedIn", WebUrl = "https://www.linkedin.com"},
                new ListItem() { WebDescription = "Reddit", WebUrl = "https://www.reddit.com"},
                new ListItem() { WebDescription = "Wikipedia", WebUrl = "https://www.wikipedia.org"},
                new ListItem() { WebDescription = "Bing", WebUrl = "https://www.bing.com"},
                new ListItem() { WebDescription = "Yahoo", WebUrl = "https://www.yahoo.com"},
                new ListItem() { WebDescription = "Amazon", WebUrl = "https://www.amazon.com"},
                new ListItem() { WebDescription = "Ebay", WebUrl = "https://www.ebay.com"},
                new ListItem() { WebDescription = "Walmart", WebUrl = "https://www.walmart.com"},
                new ListItem() { WebDescription = "Target", WebUrl = "https://www.target.com"},
                new ListItem() { WebDescription = "Apple", WebUrl = "https://www.apple.com"},
                new ListItem() { WebDescription = "Google", WebUrl = "https://www.google.com"},
                new ListItem() { WebDescription = "Microsoft", WebUrl = "https://www.microsoft.com"},
                new ListItem() { WebDescription = "GitHub", WebUrl = "https://www.github.com"},
                new ListItem() { WebDescription = "Stack Overflow", WebUrl = "https://www.stackoverflow.com"},
                new ListItem() { WebDescription = "YouTube", WebUrl = "https://www.youtube.com"},
                new ListItem() { WebDescription = "Twitter", WebUrl = "https://www.twitter.com"},
                new ListItem() { WebDescription = "Facebook", WebUrl = "https://www.facebook.com"},
                new ListItem() { WebDescription = "Instagram", WebUrl = "https://www.instagram.com"},
                new ListItem() { WebDescription = "LinkedIn", WebUrl = "https://www.linkedin.com"},
                new ListItem() { WebDescription = "Reddit", WebUrl = "https://www.reddit.com"},
                new ListItem() { WebDescription = "Wikipedia", WebUrl = "https://www.wikipedia.org"},
                new ListItem() { WebDescription = "Bing", WebUrl = "https://www.bing.com"},
                new ListItem() { WebDescription = "Yahoo", WebUrl = "https://www.yahoo.com"},
                new ListItem() { WebDescription = "Amazon", WebUrl = "https://www.amazon.com"},
                new ListItem() { WebDescription = "Ebay", WebUrl = "https://www.ebay.com"},
                new ListItem() { WebDescription = "Walmart", WebUrl = "https://www.walmart.com"},
            };
    }

}
