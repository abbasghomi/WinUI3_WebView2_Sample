using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3_WebView2_Sample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WebViewUserControl3 : UserControl
    {
        public static readonly DependencyProperty PreviewContentProperty =
            DependencyProperty.Register(nameof(PreviewContent), typeof(string), typeof(WebViewUserControl3), new PropertyMetadata(null, OnPreviewContentChanged));

        public string PreviewContent
        {
            get => (string)GetValue(PreviewContentProperty);
            set => SetValue(PreviewContentProperty, value);
        }

        private static void OnPreviewContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var uc = d as WebViewUserControl3;
            uc?.OnPreviewContentChanged((string)e.NewValue);
        }

        private void OnPreviewContentChanged(string webContent)
        {
            WebView.NavigateToString(webContent);
        }

        public WebViewUserControl3()
        {
            this.InitializeComponent();
            WebView.EnsureCoreWebView2Async();
        }
    }
}
