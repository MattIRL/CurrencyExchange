

namespace CurrencyExchange
{
    public partial class MainPage : ContentPage
    {
    private List<string> currencyList = new List<string>
        {"AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN",
        "BHD", "BIF", "BMD", "BND", "BOB", "BRL", "BSD", "BTN", "BWP", "BYN", "BZD", "CAD", "CDF", "CHF",
        "CLP", "CNY", "COP", "CRC", "CUP", "CVE", "CZK", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB",
        "EUR", "FJD", "FKP", "FOK", "GBP", "GEL", "GGP", "GIP", "GMD", "GNF", "GTQ", "GYD", "HKD", "HNL",
        "HRK", "HTG", "HUF", "IDR", "ILS", "IMP", "INR", "IQD", "IRR", "ISK", "JEP", "JMD", "JOD", "JPY",
        "KES", "KGS", "KHR", "KID", "KMF", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL",
        "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRU", "MUR", "MVR", "MWK", "MXN", "MYR",
        "MZN", "NAD", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKR", "PLN",
        "PYG", "QAR", "RON", "RSD", "RUB", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SHP", "SLE",
        "SLL", "SOS", "SRD", "SSP", "STN", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD",
        "TVD", "TWD", "TZS", "UAH", "UGX", "USD", "UYU", "UZS", "VES", "VND", "VUV", "WST", "XAF", "XCD",
        "XCG", "XDR", "XOF", "XPF", "YER", "ZAR", "ZMW", "ZWL"};
        public MainPage()
        {
            InitializeComponent();
            CurrencyPicker.ItemsSource = currencyList;

        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            // Parse decimal
            if (!decimal.TryParse(ValueDecimal.Text, out decimal number))
            {
                CurrencyResult.Text = "Invalid decimal value. Please try again.";
                return;
            }

            //
            decimal exchangeNumber = number;
            decimal exchangeRate = 1;

            // Get selected currency
            string? selectedCurrency = CurrencyPicker.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCurrency))
            {
                CurrencyResult.Text = "Please select a currency.";
                return;
            }

            // Display results
            CurrencyResult.Text = $"{number} USD is worth {exchangeNumber} {selectedCurrency}. " +
                $"That is an exchagne rate of 1:{exchangeRate}";
            roboImage.Source = $"https://www.robohash.org/{exchangeNumber}{selectedCurrency}.png";
            roboName.Text = $"This robot is named '{exchangeNumber} {selectedCurrency}'.";
        }
    }

}
