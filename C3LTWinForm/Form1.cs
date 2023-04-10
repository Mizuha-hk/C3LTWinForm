using System.DirectoryServices;
using System;
using System.Linq;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace C3LTWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            jsonString = File.ReadAllText(fileName);
            items = JsonSerializer.Deserialize<List<Item>>(jsonString);
        }

        public List<Item>? items = new List<Item>();
        public string? jsonString;
        public string fileName = "PhoneData.json";

        private void Form1_Load(object sender, EventArgs e)
        {
            InisializeListView();
            AddListItem();
        }

        //methods
        private void InisializeListView()
        {
            PhoneItemList.Columns.Add("Name", 80);
            PhoneItemList.Columns.Add("Phone Number", 150);
        }

        private void AddListItem()
        {
            PhoneItemList.Items.Clear();
            foreach (var item in items)
            {
                string[] strings = { item.Name, item.PhoneNumber };
                PhoneItemList.Items.Add(new ListViewItem(strings));
            }
        }

        private void SearchName()
        {
            PhoneItemList.Items.Clear();
            if (String.IsNullOrEmpty(SearchText.Text))
            {
                AddListItem();
            }
            else
            {
                var resultItem = items
                    .Where(x => x.Name.IndexOf(SearchText.Text) > -1);

                foreach (var item in resultItem)
                {
                    string[] strings = { item.Name, item.PhoneNumber };
                    PhoneItemList.Items.Add(new ListViewItem(strings));
                }
            }
        }

        //event handler
        private async void ApplicationButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameBox.Text) | String.IsNullOrEmpty(PhoneBox.Text))
            {
                CausionText.Text = "–¼‘O‚Æ“d˜b”Ô†‚ð“ü—Í‚µ‚Ä‚­‚¾‚³‚¢B";
            }
            else
            {
                items.Add(new Item() { Name = NameBox.Text, PhoneNumber = PhoneBox.Text });
                jsonString = JsonSerializer.Serialize(items);
                await File.WriteAllTextAsync(fileName, jsonString);
                AddListItem();
                CausionText.Text = "“o˜^¬Œ÷";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchName();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (PhoneItemList.SelectedItems.Count > 0)
            {
                var item = PhoneItemList.SelectedItems[0];

                var itemQuery = items
                    .Where(x => x.Name == item.Text);


                jsonString = JsonSerializer.Serialize(items);
                await File.WriteAllTextAsync(fileName, jsonString);
                AddListItem();
            }
        }
    }
}