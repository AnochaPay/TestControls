using System;
using System.Collections.Generic;
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

namespace TestControls {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            CreateControls();
            CreateBackgroundSubmit();
        }

        Label firstNameLabel;
        Label lastNameLabel;
        TextBox firstName;
        TextBox lastName;
        Button submit;
        Button clear;

        void CreateControls() {
            firstNameLabel = new Label();
            firstNameLabel.Content = "Enter your first name:";
            grid1.Children.Add(firstNameLabel);

            firstName = new TextBox();
            firstName.Margin = new Thickness(0, 5, 10, 5);
            Grid.SetColumn(firstName, 1);
            grid1.Children.Add(firstName);

            lastNameLabel = new Label();
            lastNameLabel.Content = "Enter your last name:";
            Grid.SetRow(lastNameLabel, 1);
            grid1.Children.Add(lastNameLabel);

            lastName = new TextBox();
            lastName.Margin = new Thickness(0, 5, 10, 5);
            Grid.SetColumn(lastName, 1);
            Grid.SetRow(lastName, 1);
            grid1.Children.Add(lastName);

            submit = new Button();
            submit.Content = "View message";
            Grid.SetRow(submit, 2);
            grid1.Children.Add(submit);

            clear = new Button();
            clear.Content = "Clear Name";
            Grid.SetRow(clear, 2);
            Grid.SetColumn(clear, 1);
            grid1.Children.Add(clear);
        }
        /// <summary>
        /// For test create button submit
        /// </summary>
        private void CreateBackgroundSubmit() {
            LinearGradientBrush buttonBrush = new LinearGradientBrush();
            buttonBrush.StartPoint = new Point(0, 0.5);
            buttonBrush.EndPoint = new Point(1, 0.5);
            buttonBrush.GradientStops.Add(new GradientStop(Colors.Green, 0));
            buttonBrush.GradientStops.Add(new GradientStop(Colors.White, 0.9));

            submit.Background = buttonBrush;
            submit.FontSize = 14;
            submit.FontWeight = FontWeights.Bold;
        }
    }
}
