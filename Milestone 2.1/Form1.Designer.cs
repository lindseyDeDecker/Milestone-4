namespace Milestone_2._1
{
    partial class inventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inventoryButton = new Button();
            lblInventory = new Label();
            lblTitle = new Label();
            dataInfo = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            addInventory = new Button();
            btnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.FromArgb(255, 128, 255);
            inventoryButton.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            inventoryButton.Location = new Point(246, 12);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(193, 68);
            inventoryButton.TabIndex = 0;
            inventoryButton.Text = "Display Inventory";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += lblInventory_Click;
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(133, 35);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(55, 22);
            lblInventory.TabIndex = 1;
            lblInventory.Text = "label1";
         
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Open Sans", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(133, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(58, 22);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "label1";
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Price, Quantity, ISBN, Genre });
            dataInfo.Location = new Point(55, 108);
            dataInfo.Name = "dataInfo";
            dataInfo.Size = new Size(1078, 462);
            dataInfo.TabIndex = 3;
           
            
            dataInfo.CellMouseClick += dataInfo_CellMouseClick;
            
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 3;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Author.HeaderText = "Author";
            Author.Name = "Author";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // ISBN
            // 
            ISBN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            // 
            // Genre
            // 
            Genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            // 
            // addInventory
            // 
            addInventory.BackColor = Color.FromArgb(255, 128, 255);
            addInventory.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            addInventory.Location = new Point(524, 12);
            addInventory.Name = "addInventory";
            addInventory.Size = new Size(167, 67);
            addInventory.TabIndex = 4;
            addInventory.Text = "Add Inventory";
            addInventory.UseVisualStyleBackColor = false;
            addInventory.Click += addInventory_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(255, 128, 255);
            btnSaveChanges.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            btnSaveChanges.Location = new Point(794, 12);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(162, 68);
            btnSaveChanges.TabIndex = 5;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // inventoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(1219, 801);
            Controls.Add(btnSaveChanges);
            Controls.Add(addInventory);
            Controls.Add(dataInfo);
            Controls.Add(lblTitle);
            Controls.Add(lblInventory);
            Controls.Add(inventoryButton);
            Font = new Font("Open Sans", 12F);
            Margin = new Padding(4);
            Name = "inventoryForm";
            ShowIcon = false;
            Text = "Inventory";
           
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inventoryButton;
        private Label lblInventory;
        private Label lblTitle;
        private DataGridView dataInfo;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Genre;
        private Button addInventory;
        private Button btnSaveChanges;
    }
}
