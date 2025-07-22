
namespace TreasurySettingsEditor
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboCharacter;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.CheckBox chkDrop;
        private System.Windows.Forms.CheckBox chkPass;
        private System.Windows.Forms.CheckBox chkLot;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.GroupBox groupAddCharacter;
        private System.Windows.Forms.GroupBox groupAddItem;
        private System.Windows.Forms.Label labelTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboCharacter = new System.Windows.Forms.ComboBox();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.chkDrop = new System.Windows.Forms.CheckBox();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.chkLot = new System.Windows.Forms.CheckBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.listItems = new System.Windows.Forms.ListBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.groupAddCharacter = new System.Windows.Forms.GroupBox();
            this.groupAddItem = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // Title label
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 30);
            this.labelTitle.Text = "Treasure Box";

            // Character selection dropdown
            this.comboCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCharacter.FormattingEnabled = true;
            this.comboCharacter.Location = new System.Drawing.Point(20, 50);
            this.comboCharacter.Name = "comboCharacter";
            this.comboCharacter.Size = new System.Drawing.Size(220, 23);
            this.comboCharacter.TabIndex = 0;
            this.comboCharacter.SelectedIndexChanged += new System.EventHandler(this.comboCharacter_SelectedIndexChanged);

            // Add Character GroupBox
            this.groupAddCharacter.Location = new System.Drawing.Point(20, 85);
            this.groupAddCharacter.Name = "groupAddCharacter";
            this.groupAddCharacter.Size = new System.Drawing.Size(220, 65);
            this.groupAddCharacter.TabIndex = 10;
            this.groupAddCharacter.TabStop = false;
            this.groupAddCharacter.Text = "Add Character";

            // txtCharacterName
            this.txtCharacterName.Location = new System.Drawing.Point(10, 25);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(120, 23);
            this.txtCharacterName.TabIndex = 1;

            // btnAddCharacter
            this.btnAddCharacter.Location = new System.Drawing.Point(140, 25);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(60, 23);
            this.btnAddCharacter.TabIndex = 2;
            this.btnAddCharacter.Text = "Add";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);

            // Add Item GroupBox
            this.groupAddItem.Location = new System.Drawing.Point(20, 160);
            this.groupAddItem.Name = "groupAddItem";
            this.groupAddItem.Size = new System.Drawing.Size(220, 90);
            this.groupAddItem.TabIndex = 11;
            this.groupAddItem.TabStop = false;
            this.groupAddItem.Text = "Add Item";

            // txtItemName
            this.txtItemName.Location = new System.Drawing.Point(10, 25);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 23);
            this.txtItemName.TabIndex = 3;

            // chkDrop
            this.chkDrop.AutoSize = true;
            this.chkDrop.Location = new System.Drawing.Point(10, 55);
            this.chkDrop.Name = "chkDrop";
            this.chkDrop.Size = new System.Drawing.Size(51, 19);
            this.chkDrop.TabIndex = 4;
            this.chkDrop.Text = "Drop";
            this.chkDrop.UseVisualStyleBackColor = true;

            // chkPass
            this.chkPass.AutoSize = true;
            this.chkPass.Location = new System.Drawing.Point(70, 55);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(50, 19);
            this.chkPass.TabIndex = 5;
            this.chkPass.Text = "Pass";
            this.chkPass.UseVisualStyleBackColor = true;

            // chkLot
            this.chkLot.AutoSize = true;
            this.chkLot.Location = new System.Drawing.Point(130, 55);
            this.chkLot.Name = "chkLot";
            this.chkLot.Size = new System.Drawing.Size(44, 19);
            this.chkLot.TabIndex = 6;
            this.chkLot.Text = "Lot";
            this.chkLot.UseVisualStyleBackColor = true;

            // btnAddItem
            this.btnAddItem.Location = new System.Drawing.Point(180, 55);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(30, 23);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            // listItems
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 15;
            this.listItems.Location = new System.Drawing.Point(20, 260);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(220, 200);
            this.listItems.TabIndex = 8;

            // btnDeleteItem
            this.btnDeleteItem.Location = new System.Drawing.Point(20, 470);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(220, 30);
            this.btnDeleteItem.TabIndex = 9;
            this.btnDeleteItem.Text = "Delete Selected";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);

            // Add controls to group boxes
            this.groupAddCharacter.Controls.Add(this.txtCharacterName);
            this.groupAddCharacter.Controls.Add(this.btnAddCharacter);
            this.groupAddItem.Controls.Add(this.txtItemName);
            this.groupAddItem.Controls.Add(this.chkDrop);
            this.groupAddItem.Controls.Add(this.chkPass);
            this.groupAddItem.Controls.Add(this.chkLot);
            this.groupAddItem.Controls.Add(this.btnAddItem);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 520);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboCharacter);
            this.Controls.Add(this.groupAddCharacter);
            this.Controls.Add(this.groupAddItem);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.btnDeleteItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(270, 520);
            this.Name = "MainForm";
            this.Text = "Treasury Box";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
