using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Text.Json.Serialization;
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

namespace WPF_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Upisi_Click(object sender, RoutedEventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.PayerName = PayerName.Text;
            invoice.PayerAdress = PayerAdress.Text;
            invoice.PayerIBAN = PayerIBAN.Text;
            invoice.PayerNumber = PayerNumber.Text;
            invoice.RecieverName = RecieverName.Text;
            invoice.RecieverAdress = RecieverAdress.Text;
            invoice.RecieverNumber = RecieverNumber.Text;
            invoice.Emergency = (bool)Emergency.IsChecked;
            invoice.Amount = Amount.Text;
            invoice.Date = Date.Text;
            invoice.Description = Description.Text;
            invoice.Model = Model.Text;
            invoice.Currency = Currency.Text;
            AddInvoiceAsync(invoice);

        }
        private static async void AddInvoiceAsync(Invoice invoice)
        {
            var body = JsonConvert.SerializeObject(invoice);
            var httpContent = new StringContent(body, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PostAsync("https://localhost:44377/api/Invoice", httpContent);

            if (httpResponse.Content != null)
            {
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
            }
        }

        private void Ispisi_Click(object sender, RoutedEventArgs e)
        {
            DisplayInvoice temp = new DisplayInvoice();
            temp.Show();
        }
        public class Tecaj
        {
            [JsonPropertyName("broj_tecajnice")]
            public string Broj_Tecajnice { get; set; }

            [JsonPropertyName("datum_primjene")]
            public string Datum_Primjene { get; set; }

            [JsonPropertyName("drzava")]
            public string Drzava { get; set; }

            [JsonPropertyName("drzava_iso")]
            public string Drzava_Iso { get; set; }

            [JsonPropertyName("sifra_valute")]
            public string Sifra_Valute { get; set; }

            [JsonPropertyName("valuta")]
            public string Valuta { get; set; }

            [JsonPropertyName("jedinica")]
            public int Jedinica { get; set; }

            [JsonPropertyName("kupovni_tecaj")]
            public string Kupovni_Tecaj { get; set; }

            [JsonPropertyName("srednji_tecaj")]
            public string Srednji_Tecaj { get; set; }

            [JsonPropertyName("prodajni_tecaj")]
            public string Prodajni_Tecaj { get; set; }
        }
        static async Task<List<Tecaj>> GetTecajAsync(string api)
        {
            List<Tecaj> model = null;
            HttpResponseMessage response = await client.GetAsync(api);
            //Console.WriteLine(response.Content);
            if (response.IsSuccessStatusCode)
            {
                model = await response.Content.ReadAsAsync<List<Tecaj>>();
            }
            return model;
        }

        private async void IspisiTecaj_Click(object sender, RoutedEventArgs e)
        {
            string currency = Currency.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last();
            if (Amount.Text == "")
            {
                return;
            }
            float amount = float.Parse(Amount.Text);
            if (currency != "EUR" && currency != "USD")
            {
                return;
            }
            List<Tecaj> currencyModels = await GetTecajAsync($"https://api.hnb.hr/tecajn/v2?valuta={currency}");
            Tecaj currencyModel = currencyModels.First();
            float srednjiTecaj = float.Parse(currencyModel.Srednji_Tecaj);
            float izracun = amount * srednjiTecaj;
            TecajIspis.Text = izracun.ToString();
        }
    }
}
