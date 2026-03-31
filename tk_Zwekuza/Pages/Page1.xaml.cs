using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace tk_Zwekuza
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public static float otv;
        public Page1()
        {
            InitializeComponent();
        }

        private void Plus_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x.Text, out float x1);
            float.TryParse(y.Text, out float y1);

            MathPlus(x1, y1);
        }

        private void Minus_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x.Text, out float x1);
            float.TryParse(y.Text, out float y1);

            MathMinus(x1, y1);
        }

        private void Ymn_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x.Text, out float x1);
            float.TryParse(y.Text, out float y1);

            MathYmn(x1, y1);
        }

        private void Del_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x.Text, out float x1);
            float.TryParse(y.Text, out float y1);

            MathDel(x1, y1);
        }

        public bool MathPlus(float x1, float y1)
        {
            otv = x1 + y1;
            return true;
        }
        public bool MathMinus(float x1, float y1)
        {
            otv = x1 - y1;
            return true;
        }
        public bool MathYmn(float x1, float y1)
        {
            otv = x1 * y1;
            return true;
        }
        public bool MathDel(float x1, float y1)
        {
            if (y1 == 0)
            {
                MessageBox.Show("на 0 делить нельзя!");
                Del.IsChecked = false;
                return false;
            }
            else
            {
                otv = x1 / y1;
                return true;
            }
        }

        private void Rezult_Click(object sender, RoutedEventArgs e)
        {
            rez.Text = otv.ToString();
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            x.Text = String.Empty;
            y.Text = String.Empty;
            rez.Text = String.Empty;
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true;
                    break;
                }
            }
        }
    }
}
