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
using Windows.UI.Xaml.Navigation;
using static System.Net.Mime.MediaTypeNames;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DylanDeSouzaVictorianMoneyTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //currencyTextBlock.Text in row 1 is pounds
            //currencyTextBlock.Text in row 2 is crowns
            //currencyTextBlock.Text in row 3 is shilling
            //currencyTextBlock.Text in row 4 is pence
            //currencyTextBlock.Text in row 5 is farthing
        }

        private void ClickArrow(object sender, RoutedEventArgs e)
        {
            // Perform subtraction if sender is in the second column else perform addition
        }
    }
}
