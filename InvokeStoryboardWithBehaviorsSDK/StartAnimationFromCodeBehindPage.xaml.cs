using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace InvokeStoryboardWithBehaviorsSDK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartAnimationFromCodeBehindPage : Page
    {
        public StartAnimationFromCodeBehindPage()
        {
            this.InitializeComponent();
        }

        private void BorderContainer_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            var storyboard = (Storyboard)(sender as FrameworkElement).Resources["ShowPanel"];
            storyboard.Begin();
        }

        private void BorderContainer_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            var storyboard = (Storyboard)(sender as FrameworkElement).Resources["ClosePanel"];
            storyboard.Begin();
        }

    }
}
