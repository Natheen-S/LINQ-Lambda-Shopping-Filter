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

namespace LINQ___Lambda_Shopping_Filter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Products> oproducts;
        public MainWindow()
        {
            InitializeComponent();
            txtcost_from.Text = 0.ToString();
            txtcost_to.Text = 0.ToString();
            oproducts = new List<Products>()
            {
            new Products { PID = 1001, PName = "Apple Iphone 12", PPrice = 40990, PRatings = 4.4, PPrime = "Prime", PPopularity = 202 },
            new Products { PID = 1002, PName = "Apple Iphone 12 Pro", PPrice = 60990, PRatings = 4.5, PPrime = "Prime", PPopularity = 311 },
            new Products { PID = 1003, PName = "Apple Iphone 12 Pro Max", PPrice = 80990, PRatings = 4.8, PPrime = "Prime", PPopularity = 190 },
            new Products { PID = 1004, PName = "Apple Iphone 13", PPrice = 50990, PRatings = 4.9, PPrime = "Prime", PPopularity = 999 },
            new Products { PID = 1005, PName = "Apple Iphone 13 Pro", PPrice = 70990, PRatings = 4.8, PPrime = "Prime", PPopularity = 296 },
            new Products { PID = 1006, PName = "Apple Iphone 13 Pro Max", PPrice = 90990, PRatings = 4.8, PPrime = "Prime", PPopularity = 372 },
            new Products { PID = 1007, PName = "Apple Iphone 14", PPrice = 60990, PRatings = 4.7, PPrime = "Prime", PPopularity = 649 },
            new Products { PID = 1008, PName = "Apple Iphone 14 Pro", PPrice = 80990, PRatings = 4.9, PPrime = "Prime", PPopularity = 987 },
            new Products { PID = 1009, PName = "Apple Iphone 14 Pro Max", PPrice = 110990, PRatings = 5.0, PPrime = "Prime", PPopularity = 789 },
            new Products { PID = 1011, PName = "Samsung S21", PPrice = 45990, PRatings = 4.7, PPrime = "Prime", PPopularity = 205 },
            new Products { PID = 1012, PName = "Samsung S21 Ultra", PPrice = 70990, PRatings = 4.8, PPrime = "Prime", PPopularity = 254 },
            new Products { PID = 1012, PName = "Samsung S21 FE", PPrice = 40990, PRatings = 4.9, PPrime = "Prime", PPopularity = 764 },
            new Products { PID = 1013, PName = "Samsung S22", PPrice = 60990, PRatings = 4.6, PPrime = "Prime", PPopularity = 531 },
            new Products { PID = 1014, PName = "Samsung S22 Ultra", PPrice = 100990, PRatings = 4.8, PPrime = "Prime", PPopularity = 756 },
            new Products { PID = 1015, PName = "Samsung A31", PPrice = 28990, PRatings = 4.4, PPrime = "Not Prime", PPopularity = 1123 },
            new Products { PID = 1016, PName = "Samsung A51", PPrice = 35990, PRatings = 4.5, PPrime = "Not Prime", PPopularity = 1422 },
            new Products { PID = 1017, PName = "Samsung A71", PPrice = 40990, PRatings = 4.6, PPrime = "Prime", PPopularity = 133 },
            new Products { PID = 1018, PName = "Samsung M31", PPrice = 20990, PRatings = 4.1, PPrime = "Not Prime", PPopularity = 432 },
            new Products { PID = 1019, PName = "Samsung M51", PPrice = 30990, PRatings = 4.2, PPrime = "Prime", PPopularity = 432 },
            new Products { PID = 1010, PName = "Samsung M52", PPrice = 32990, PRatings = 4.3, PPrime = "Prime", PPopularity = 434 },
            new Products { PID = 10101, PName = "Samsung A02", PPrice = 11990, PRatings = 3.9, PPrime = "Not Prime", PPopularity = 989 },
            new Products { PID = 10102, PName = "Samsung M04", PPrice = 9990, PRatings = 2.9, PPrime = "Not Prime", PPopularity = 758 },
            new Products { PID = 1021, PName = "Oneplus 11", PPrice = 55990, PRatings = 4.7, PPrime = "Prime", PPopularity = 20 },
            new Products { PID = 1022, PName = "Oneplus 11R", PPrice = 39990, PRatings = 4.6, PPrime = "Prime", PPopularity = 2 },
            new Products { PID = 1023, PName = "Vivo V29", PPrice = 30990, PRatings = 4.2, PPrime = "Prime", PPopularity = 255 },
            new Products { PID = 1024, PName = "Vivo X80 Pro", PPrice = 60990, PRatings = 4.8, PPrime = "Prime", PPopularity = 602 },
            new Products { PID = 1025, PName = "Oppo Reno 8 Pro", PPrice = 47990, PRatings = 4.5, PPrime = "Prime", PPopularity = 802 },
            new Products { PID = 1026, PName = "Oppo Reno 8", PPrice = 37990, PRatings = 4.3, PPrime = "Prime", PPopularity = 689 },
            new Products { PID = 1027, PName = "Oppo Find X6", PPrice = 67990, PRatings = 4.9, PPrime = "Prime", PPopularity = 12 },
            };
            lst_products.ItemsSource = oproducts;
        }

        private void chk_prime_Checked(object sender, RoutedEventArgs e)
        {
            if (chk_prime.IsChecked == true)
            {



                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    string prime = "Prime";
                    var check1 = oproducts.Where(x => x.PName == "Prime" && x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value));
                                
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = check1;

                }
                else
                {
                    // lst_products.Items.Clear();
                    var check = oproducts.Where(x => x.PName == "Prime");
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = check;
                }

            }
            else if (chk_prime.IsChecked == false)
            {
                lst_products.ItemsSource = null;
                lst_products.ItemsSource = oproducts;
            }
        }

        

        private void rdb_low_Checked(object sender, RoutedEventArgs e)
        {
            if (rdb_low.IsChecked == true)
            {
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    var low1 = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value)).OrderBy(x => x.PPrice);
                    //var low = oproducts.OrderBy(x => x.PRatings).ThenBy(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low1;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var low = oproducts.OrderBy(x => x.PPrice).ThenBy(x => x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low;
                }
            }
        }

        private void rdb_high_Checked(object sender, RoutedEventArgs e)
        {
            if (rdb_high.IsChecked == true)
            {
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);

                    var low = oproducts.OrderByDescending(x => x.PPrice).ThenBy(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var low = oproducts.OrderByDescending(x => x.PPrice).ThenBy(x => x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low;
                }
            }
        }

        private void rdb_pop_Checked(object sender, RoutedEventArgs e)
        {
            if (rdb_pop.IsChecked == true)
            {
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    var low = oproducts.OrderByDescending(x => x.PPopularity).ThenBy(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var low = oproducts.OrderByDescending(x => x.PPopularity).ThenBy(x => x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low;
                }
            }

        }

        private void rdb_ratings_Checked(object sender, RoutedEventArgs e)
        {
            if (rdb_ratings.IsChecked == true)
            {
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    var low = oproducts.OrderByDescending(x => x.PRatings).ThenBy(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var low = oproducts.OrderByDescending(x => x.PRatings).ThenBy(x=> x.PName.Contains(value)); //oproducts.Where(x=>x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = low;
                }
            }
        }

        private void rdb_apple_Checked(object sender, RoutedEventArgs e)
        {
            if (rdb_apple.IsChecked == true)
            {
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    string model = rdb_apple.Content.ToString();
                    var apple = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
                else
                {
                    string model = rdb_apple.Content.ToString();
                    string value = txtbox_search.Text;
                    var apple = oproducts.Where(x => x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
            }
            if (rdb_oneplus.IsChecked == true)
            {
                string model = rdb_oneplus.Content.ToString();
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    //string value = rdb_oneplus.Content.ToString();
                    var apple = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var apple = oproducts.Where(x => x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
            }
            if (rdb_samsung.IsChecked == true)
            {
                string model = rdb_samsung.Content.ToString();
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    //string value = rdb_samsung.Content.ToString();
                    var apple = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var apple = oproducts.Where(x => x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
            }
            if (rdb_oppo.IsChecked == true)
            {
                string model = rdb_oppo.Content.ToString();
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    // string value = rdb_oppo.Content.ToString();
                    var apple = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var apple = oproducts.Where(x => x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
            }
            if (rdb_vivo.IsChecked == true)
            {
                string model = rdb_vivo.Content.ToString();
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    // string value = rdb_vivo.Content.ToString();
                    var apple = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var apple = oproducts.Where(x=>x.PName.Contains(value) && x.PName.Contains(model));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }

            }
            if (rdb_all.IsChecked == true)
            {
                if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
                {
                    string value = txtbox_search.Text;
                    int start = Convert.ToInt32(txtcost_from.Text);
                    int end = Convert.ToInt32(txtcost_to.Text);
                    // string value = rdb_all.Content.ToString();
                    var apple = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
                else
                {
                    string value = txtbox_search.Text;
                    var apple = oproducts.Where(x => x.PName.Contains(value));
                    lst_products.ItemsSource = null;
                    lst_products.ItemsSource = apple;
                }
            }
        }

        

        private void btn_cost_Click(object sender, RoutedEventArgs e)
        {
            if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
            {
                string value = txtbox_search.Text;
                int start = Convert.ToInt32(txtcost_from.Text);
                int end = Convert.ToInt32(txtcost_to.Text);
                var cost = oproducts.Where(x => x.PPrice >= start && x.PPrice <= end && x.PName.Contains(value));
                lst_products.ItemsSource = null;
                lst_products.ItemsSource = cost;
            }
            else
            {
                string value = txtbox_search.Text;
                var cost = oproducts.Where(x => x.PName.Contains(value));
                          
                lst_products.ItemsSource = null;
                lst_products.ItemsSource = cost;
            }
        }

        private void txtbox_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtcost_from.Text != 0.ToString() && txtcost_to.Text != 0.ToString())
            {
                int start = Convert.ToInt32(txtcost_from.Text);
                int end = Convert.ToInt32(txtcost_to.Text);
                string value = txtbox_search.Text;
                var val = oproducts.Where(x=>x.PName.Contains(value) && x.PPrice >=start && x.PPrice<=end);
                lst_products.ItemsSource = null;
                lst_products.ItemsSource = val;
            }
            else
            {
                string value = txtbox_search.Text;
                var val = oproducts.Where(x => x.PName.Contains(value));
                lst_products.ItemsSource = null;
                lst_products.ItemsSource = val;
            }
        }
    }
}
