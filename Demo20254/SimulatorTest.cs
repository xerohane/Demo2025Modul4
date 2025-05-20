using System.Text.Json;
using System.Text.RegularExpressions;

namespace Demo20254
{
    public partial class SimulatorTest : Form
    {
        public SimulatorTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetLabel_Click(object sender, EventArgs e)
        {

        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://prb.sylas.ru/TransferSimulator/");

            var resp = client.GetAsync("fullName").Result;
            string respText = resp.Content.ReadAsStringAsync().Result;

            var obj = JsonSerializer.Deserialize<JsonObject>(respText);

            GetLabel.Text = obj.value;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            bool hasInvalidChars = Regex.IsMatch(GetLabel.Text, @"[^\w\s]");
            if (hasInvalidChars)
            {
                Setlabel.Text = "Фио содержит запрещенные символы";
            }
            else
            {
                Setlabel.Text = "Фио не содержит запрещенные символы";
            }
        }
    }
}
