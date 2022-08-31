using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DoubleTapMobile.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameIconNavigationPage : TabbedPage
    {
        public GameIconNavigationPage()
        {
            this.InitializeComponent();
        }
    }
}