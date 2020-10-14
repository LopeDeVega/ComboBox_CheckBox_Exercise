using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace _27._1.ListBox.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //App which hold Cities and their temperature. it will compare the data..
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //(ListB.SelectedItem as Cities).Temperature_1 - (ListB.SelectedItem as Cities).Temperature_2
            //    temperature = (ListB.SelectedItem as Cities).Temperature_1 - (ListB.SelectedItem as Cities).Temperature_2
            //    temperature = (ListB.SelectedItem as Cities).Temperature_1 - (ListB.SelectedItem as Cities).Temperature_2
            //    temperature = (ListB.SelectedItem as Cities).Temperature_1 - (ListB.SelectedItem as Cities).Temperature_

            Cities cityTemp = new Cities(); 

            //Creating a list which hold the Cities
            List<Cities> City = new List<Cities>();
            //Adding to the list the Cities and temperature
            City.Add(new Cities() {City_1 = "Manchester", City_2 = "Liverpool",  Temperature_1 = 10, Temperature_2 = 8, temperature = 2});
            City.Add(new Cities() {City_1 = "Newcastle", City_2 = "Cardiff",  Temperature_1 = 9, Temperature_2 = 13, temperature = 4 });
            City.Add(new Cities() {City_1 = "Leeds", City_2 = "Bristol",  Temperature_1 = 5, Temperature_2 = 14, temperature = 9 });
            City.Add(new Cities() {City_1 = "York", City_2 = "Oxford",  Temperature_1 = 6, Temperature_2 = 2, temperature = 4 });

            //Inserting List(City) data into the ListBox
            ListB.ItemsSource = City;

            

        }

        //Select a row from the listBox and then press the button 
        //A MessageBox will display the info of the row ()
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //--------------------------------------Try and Catch to avoid the program breaks when there is not item selected.-----------------------------//
            try
            {
                //another way to avoid the app break
                //if (ListB.SelectedItem != null)
                //{
                    //Show a MessageBox whit the info.
                    //ListB = xaml listBox
                    MessageBox.Show((ListB.SelectedItem as Cities).City_1 + " " +
                        (ListB.SelectedItem as Cities).Temperature_1 + " Degrees  " +
                        (ListB.SelectedItem as Cities).City_2 + " " +
                        (ListB.SelectedItem as Cities).Temperature_2 + " Degrees ");

                //Podemos anadir la diferencia de temperatura
                //Podemos anadir la diferencia de temperatura
               

                // }

            }
            //catching the exception 
            catch (System.NullReferenceException)
            {
                
                MessageBox.Show("Please Select an Option From the ListBox");
            }

        }
//-------------------------------------------------------------------------------------Display the Value of Index 1 -------------------------------------//

        //DoubleClick on listBox Item (2) // Will display MessageBox of index (1).
        private void ListB_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
                //if ListB index (1) is not null / return the value
                //We could also use try and catch used in the button which avoid to break the application when you click and nothing is selected
                if ( ListB.SelectedIndex == 1)
                {
                    MessageBox.Show((ListB.SelectedItem as Cities).City_1 + " " +
                    (ListB.SelectedItem as Cities).Temperature_1 + " Degrees  " +
                    (ListB.SelectedItem as Cities).City_2 + " " +
                    (ListB.SelectedItem as Cities).Temperature_2 + " Degrees ");

                }
                //this message will be displayed when a row is selected and click on any column is not fourth column
                else
                {
                 MessageBox.Show("Please Select an Item on four column and the info will be displayed");


                }
            //int diff1 = ((ListB.SelectedItem as Cities).Temperature_1);
            //MessageBox.Show(diff1.ToString());

        }


        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListB.SelectedItem != null)
            {

                MessageBox.Show((ListB.SelectedItem as Cities).City_1 + " " +
                   (ListB.SelectedItem as Cities).Temperature_1 + " Degrees  " +
                   (ListB.SelectedItem as Cities).City_2 + " " +
                   (ListB.SelectedItem as Cities).Temperature_2 + " Degrees ");
            }
        }
    }

    //Creating a new Class Cities

    public class Cities
    {

        public string City_1 { get; set; }

        public int Temperature_1 { get; set; }
        public string City_2 { get; set; }
        public int Temperature_2 { get; set; }

        public int temperature { get; set; }



   



    }

}
