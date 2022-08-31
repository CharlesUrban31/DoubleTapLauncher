using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DoubleTapMobile.Views
{
    /// <summary>
    /// Page to display on-boarding gradient with animation
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalkThroughPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalkThroughPage" /> class.
        /// </summary>
        public WalkThroughPage()
        {
            this.InitializeComponent();
        }
    }
}