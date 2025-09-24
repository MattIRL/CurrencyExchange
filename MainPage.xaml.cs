

namespace CurrencyExchange
{
    public partial class MainPage : ContentPage
    {
        // List of all available currencies from API
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

        //--------------------------------------
        // Placeholder for API related variables
        //--------------------------------------


        public MainPage()
        {
            InitializeComponent();
            FromCurrencyPicker.ItemsSource = currencyList;
            ToCurrencyPicker.ItemsSource = currencyList;

        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {

            // Parse decimal from User Entry
            if (!decimal.TryParse(ValueDecimal.Text, out decimal number))
            {
                CurrencyResult.Text = "Invalid decimal value. Please try again.";
                return;
            }

            //-------------------------------------------------------
            // Placeholder for currency calculations and method calls
            //-------------------------------------------------------
            decimal exchangeNumber = number;
            decimal exchangeRate = 1;


            // Get selected currency
            string? ToCurrency = ToCurrencyPicker.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(ToCurrency))
            {
                CurrencyResult.Text = "Please select To and From currency.";
                return;
            }

            //-----------------------------
            //Placeholder for Live API Call
            //-----------------------------


            // Update text with JSON code
            apiResponseEditor.Text = "JSON code to go here...\n\nNMC CIT255 Rocks!";

            // Display results
            CurrencyResult.Text = $"{number} USD is worth {exchangeNumber} {ToCurrency}. " +
                $"That is an exchagne rate of 1:{exchangeRate}";
            roboImage.Source = $"https://www.robohash.org/{exchangeNumber}{ToCurrency}.png";
            roboName.Text = $"This robot is named '{exchangeNumber} {ToCurrency}'.";
        }

        // Show JSON button logic
        private void OnToggleJsonClicked(object sender, EventArgs e)
        {
            apiResponseEditor.IsVisible = !apiResponseEditor.IsVisible;
        }
    }

}
