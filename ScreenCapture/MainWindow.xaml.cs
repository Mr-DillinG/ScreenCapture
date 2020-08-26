using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ScreenCapture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //What happens when you press the capture button
            
            //Filename for the saved screenshot
            string filename = "ScreenCapture" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".jpeg";
            
            //Size of the screenshot
            int screenLeft = (int)SystemParameters.VirtualScreenLeft;
            int screenTop = (int)SystemParameters.VirtualScreenTop;
            int screenWidth = (int)SystemParameters.VirtualScreenWidth;
            int screenHeight = (int)SystemParameters.VirtualScreenHeight;

            //Creating the bitmap and adding the screenshot to the bitmap
            Bitmap bitmap_screen = new Bitmap(screenWidth, screenHeight);
            Graphics g = Graphics.FromImage(bitmap_screen);
            
            //Saving the screenshot
            g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap_screen.Size);

            bitmap_screen.Save("C:\\Screenshots\\" + filename);
        }
    }
}
