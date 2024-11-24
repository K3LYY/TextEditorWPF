using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZadanieOcena_12._11._2024
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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void textToLabel(object sender, TextChangedEventArgs e)
        {
            string text = main_Textbox.Text;
            final_Label_Text.Text = text;
        }
        private void Alignment_Horizontal_Changed(object sender, EventArgs e)
        {
            if(Alignment_Horizontal_Center.IsChecked == true){
                final_Label.HorizontalAlignment = HorizontalAlignment.Center;
            }
            if(Alignment_Horizontal_Left.IsChecked == true)
            {
                final_Label.HorizontalAlignment= HorizontalAlignment.Left;
            }
            if(Alignment_Horizontal_Right.IsChecked == true)
            {
                final_Label.HorizontalAlignment = HorizontalAlignment.Right;
            }
        }
        private void Alignment_Vertical_Changed(object sender, EventArgs e)
        {
            if(Alignment_Vertical_Bottom.IsChecked == true)
            {
                final_Label.VerticalAlignment = VerticalAlignment.Bottom;
            }
            if(Alignment_Vertical_Center.IsChecked == true)
            {
                final_Label.VerticalAlignment= VerticalAlignment.Center;
            }
            if(Alignment_Vertical_Top.IsChecked == true)
            {
                final_Label.VerticalAlignment= VerticalAlignment.Top;
            }
        }
        private void Alignment_Content_Horizontal_Changed(object sender, EventArgs e)
        {
            if(Alignment_Content_Horizontal_Left.IsChecked==true)
            {
                final_Label.HorizontalContentAlignment = HorizontalAlignment.Left;
            }
            if(Alignment_Content_Horizontal_Center.IsChecked == true)
            {
                final_Label.HorizontalContentAlignment= HorizontalAlignment.Center;
            }
            if (Alignment_Content_Horizontal_Right.IsChecked == true)
            {
                final_Label.HorizontalContentAlignment = HorizontalAlignment.Right;
            }
        }
        private void Alignment_Content_Vertical_Changed(object sender, EventArgs e)
        {
            if (Alignment_Content_Vertical_Top.IsChecked == true)
            {
                final_Label.VerticalContentAlignment = VerticalAlignment.Top;
            }
            if (Alignment_Content_Vertical_Center.IsChecked == true)
            {
                final_Label.VerticalContentAlignment = VerticalAlignment.Center;
            }
            if (Alignment_Content_Vertical_Bottom.IsChecked == true)
            {
                final_Label.VerticalContentAlignment = VerticalAlignment.Bottom;
            }
        }
        private void Font_Family_Changed(object sender, EventArgs e)
        {
            if (Font_1.IsSelected == true)
            {
                final_Label.FontFamily = new System.Windows.Media.FontFamily("Arial");
            }
            else if (Font_2.IsSelected == true)
            {
                final_Label.FontFamily = new System.Windows.Media.FontFamily("Tahoma");
            }
        }
        private void Font_Size_Changed(object sender, EventArgs e)
        {
            if (Font_Size.Text == "")
            {
                final_Label_Text.FontSize = 1;
            }
            else
            {
                int fontSize = Convert.ToInt32(Font_Size.Text);
                final_Label_Text.FontSize = fontSize;
            }
        }
        private void Font_Weight_Changed(object sender, EventArgs e)
        {
            if(Font_Bold.IsChecked == true)
            {
                final_Label_Text.FontWeight = FontWeights.Bold;
            }
            if(Font_Italic.IsChecked == true)
            {
                final_Label_Text.FontStyle = FontStyles.Italic;
            }
            if(Font_Bold.IsChecked == false)
            {
                final_Label_Text.FontWeight = FontWeights.Normal;
            }
            if(Font_Italic.IsChecked == false)
            {
                final_Label_Text.FontStyle = FontStyles.Normal;
            }
        }
        private void Font_Margin_Padding_Changed(object sender, EventArgs e)
        {
            int margin = Convert.ToInt32(Text_Margin.Value);
            final_Label.Margin = new Thickness(margin);
        }
        private void Font_Margin_Padding_ChangedTest(object sender, EventArgs e)
        {
            int padding = Convert.ToInt32(Text_Padding.Value);
            final_Label.Padding = new Thickness(padding);
        }
        private void Background_Color_Changed(object sender, EventArgs e)
        {
            byte red = Convert.ToByte(Background_Red.Value);
            byte green = Convert.ToByte(Background_Green.Value);
            byte blue = Convert.ToByte(Background_Blue.Value);
            final_Label.Background = new SolidColorBrush(Color.FromRgb(red,green,blue));
        }
        private void Foreground_Color_Changed(object sender, EventArgs e)
        {
            byte red = 0, green = 0, blue = 0;

            // Próbuj konwertować wartości z TextBox na byte, używając TryParse
            if (byte.TryParse(Foreground_Red.Text, out byte parsedRed))
            {
                red = parsedRed;
            }

            if (byte.TryParse(Foreground_Green.Text, out byte parsedGreen))
            {
                green = parsedGreen;
            }

            if (byte.TryParse(Foreground_Blue.Text, out byte parsedBlue))
            {
                blue = parsedBlue;
            }
            final_Label_Text.Foreground = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
        private void Border_Color_Changed(object sender, EventArgs e)
        {
            if(Border_Black.IsSelected == true)
            {
                final_Label.BorderBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
            else if(Border_Red.IsSelected == true)
            {
                final_Label.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else if (Border_Green.IsSelected == true)
            {
                final_Label.BorderBrush = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else if (Border_Blue.IsSelected == true)
            {
                final_Label.BorderBrush = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            }
        }
        private void Border_Thickness_Changed(object sender, EventArgs e)
        {
            int thickness = Convert.ToInt32(Border_Thickness.Value);
            final_Label.BorderThickness = new Thickness(thickness);
        }
    }
}