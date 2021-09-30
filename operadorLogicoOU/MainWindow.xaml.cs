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

namespace operadorLogicoOU
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            string cupom;
            double valorCompra, valorFinal;

            cupom = txtCupom.Text.ToUpper();
            valorCompra = Convert.ToDouble(txtTotalCompra.Text);

            if(valorCompra>1000 || cupom == "DESCONTO20")
            {
                valorFinal = valorCompra - (valorCompra * 0.2);
            }
            else
            {
                valorFinal = valorCompra;
            }
            MessageBox.Show("Valor Final de sua compra: R$" + valorFinal.ToString("0.00"),
                "Compra", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
