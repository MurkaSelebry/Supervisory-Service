using System.Text;
namespace MapTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            string state = textBoxState.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;
            string zipCode = textBoxZip.Text;
            StringBuilder querryAdress = new StringBuilder();
            querryAdress.Append("http://google.com/maps?q=");
            if (!string.IsNullOrEmpty(state))
                querryAdress.Append(state + "," + "+");
            if (!string.IsNullOrEmpty(city))
                querryAdress.Append(city + "," + "+");
            if (!string.IsNullOrEmpty(street))
                querryAdress.Append(street + "," + "+");
            if (!string.IsNullOrEmpty(zipCode))
                querryAdress.Append(zipCode + "," + "+");
            webBrowser1.Navigate(querryAdress.ToString());
        }
    }
}