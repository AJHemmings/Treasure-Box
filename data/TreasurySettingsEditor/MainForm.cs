using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace TreasurySettingsEditor
{
    public partial class MainForm : Form
    {
        private string settingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");
        private XDocument settingsDoc;
        private List<string> characterNames = new List<string>();
        private string activeSection = "global";

        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
            PopulateCharacterDropdown();
            UpdateItemList();
        }

        private void LoadSettings()
        {
            settingsDoc = XDocument.Load(settingsPath);
            characterNames = settingsDoc.Root.Elements()
                .Where(e => e.Name.LocalName != "global")
                .Select(e => e.Name.LocalName)
                .ToList();
        }

        private void PopulateCharacterDropdown()
        {
            comboCharacter.Items.Clear();
            comboCharacter.Items.Add("global");
            foreach (var name in characterNames)
                comboCharacter.Items.Add(name);
            comboCharacter.SelectedIndex = 0;
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            var name = txtCharacterName.Text.Trim();
            if (string.IsNullOrEmpty(name) || characterNames.Contains(name)) return;
            settingsDoc.Root.Add(new XElement(name));
            settingsDoc.Save(settingsPath);
            LoadSettings();
            PopulateCharacterDropdown();
        }

        private void comboCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeSection = comboCharacter.SelectedItem.ToString();
            UpdateItemList();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var itemName = txtItemName.Text.Trim();
            if (string.IsNullOrEmpty(itemName)) return;
            var section = settingsDoc.Root.Element(activeSection);
            if (section == null) return;
            if (chkDrop.Checked) AddItemToList(section, "Drop", itemName);
            if (chkPass.Checked) AddItemToList(section, "Pass", itemName);
            if (chkLot.Checked) AddItemToList(section, "Lot", itemName);
            settingsDoc.Save(settingsPath);
            UpdateItemList();
        }

        private void AddItemToList(XElement section, string listName, string itemName)
        {
            var el = section.Element(listName);
            if (el == null)
            {
                el = new XElement(listName);
                section.Add(el);
            }
            var items = el.Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            if (!items.Contains(itemName))
            {
                items.Add(itemName);
                items.Sort();
                el.Value = string.Join(",", items);
            }
        }

        private void UpdateItemList()
        {
            listItems.Items.Clear();
            var section = settingsDoc.Root.Element(activeSection);
            if (section == null) return;
            foreach (var type in new[] { "Drop", "Pass", "Lot" })
            {
                var el = section.Element(type);
                if (el != null && !string.IsNullOrWhiteSpace(el.Value))
                {
                    var items = el.Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).OrderBy(x => x);
                    foreach (var item in items)
                        listItems.Items.Add($"[{type}] {item}");
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItem == null) return;
            var selected = listItems.SelectedItem.ToString();
            var type = selected.Substring(1, selected.IndexOf(']') - 1);
            var itemName = selected.Substring(selected.IndexOf(']') + 2);
            var section = settingsDoc.Root.Element(activeSection);
            var el = section.Element(type);
            if (el != null)
            {
                var items = el.Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                items.Remove(itemName);
                el.Value = string.Join(",", items);
                settingsDoc.Save(settingsPath);
                UpdateItemList();
            }
        }
    }
}
