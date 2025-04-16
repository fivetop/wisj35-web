using Wisej.Web;

namespace WebTestApp
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://www.lssimple.co.kr");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
