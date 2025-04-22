namespace Assignment1_DIC_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListBox();
            this.shirt = new System.Windows.Forms.Button();
            this.shoes = new System.Windows.Forms.Button();
            this.hat = new System.Windows.Forms.Button();
            this.hatRemove = new System.Windows.Forms.Button();
            this.shoesRemove = new System.Windows.Forms.Button();
            this.shirtRemove = new System.Windows.Forms.Button();
            this.shirtCounter = new System.Windows.Forms.Label();
            this.hatCounter = new System.Windows.Forms.Label();
            this.shoeCounter = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to My Awesome Store!";
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(83, 101);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(143, 31);
            this.purchaseButton.TabIndex = 1;
            this.purchaseButton.Text = "Make a Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(83, 130);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(143, 31);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Make a Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(83, 159);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(143, 31);
            this.inventoryButton.TabIndex = 3;
            this.inventoryButton.Text = "Manage Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(83, 188);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(143, 33);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Make a Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // itemList
            // 
            this.itemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 29;
            this.itemList.Items.AddRange(new object[] {
            "Shirt($250)",
            "Shoes($600)",
            "Hat($200)"});
            this.itemList.Location = new System.Drawing.Point(389, 114);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(160, 91);
            this.itemList.TabIndex = 5;
            this.itemList.Visible = false;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // shirt
            // 
            this.shirt.Location = new System.Drawing.Point(579, 115);
            this.shirt.Name = "shirt";
            this.shirt.Size = new System.Drawing.Size(60, 25);
            this.shirt.TabIndex = 6;
            this.shirt.Text = "Add";
            this.shirt.UseVisualStyleBackColor = true;
            this.shirt.Visible = false;
            this.shirt.Click += new System.EventHandler(this.shirt_Click);
            // 
            // shoes
            // 
            this.shoes.Location = new System.Drawing.Point(579, 146);
            this.shoes.Name = "shoes";
            this.shoes.Size = new System.Drawing.Size(60, 25);
            this.shoes.TabIndex = 7;
            this.shoes.Text = "Add";
            this.shoes.UseVisualStyleBackColor = true;
            this.shoes.Visible = false;
            this.shoes.Click += new System.EventHandler(this.shoes_Click);
            // 
            // hat
            // 
            this.hat.Location = new System.Drawing.Point(579, 177);
            this.hat.Name = "hat";
            this.hat.Size = new System.Drawing.Size(60, 25);
            this.hat.TabIndex = 8;
            this.hat.Text = "Add";
            this.hat.UseVisualStyleBackColor = true;
            this.hat.Visible = false;
            this.hat.Click += new System.EventHandler(this.hat_Click);
            // 
            // hatRemove
            // 
            this.hatRemove.Location = new System.Drawing.Point(279, 179);
            this.hatRemove.Name = "hatRemove";
            this.hatRemove.Size = new System.Drawing.Size(94, 25);
            this.hatRemove.TabIndex = 12;
            this.hatRemove.Text = "Remove";
            this.hatRemove.UseVisualStyleBackColor = true;
            this.hatRemove.Visible = false;
            this.hatRemove.Click += new System.EventHandler(this.hatRemove_Click);
            // 
            // shoesRemove
            // 
            this.shoesRemove.Location = new System.Drawing.Point(279, 148);
            this.shoesRemove.Name = "shoesRemove";
            this.shoesRemove.Size = new System.Drawing.Size(94, 25);
            this.shoesRemove.TabIndex = 11;
            this.shoesRemove.Text = "Remove";
            this.shoesRemove.UseVisualStyleBackColor = true;
            this.shoesRemove.Visible = false;
            this.shoesRemove.Click += new System.EventHandler(this.shoesRemove_Click);
            // 
            // shirtRemove
            // 
            this.shirtRemove.Location = new System.Drawing.Point(279, 117);
            this.shirtRemove.Name = "shirtRemove";
            this.shirtRemove.Size = new System.Drawing.Size(94, 25);
            this.shirtRemove.TabIndex = 10;
            this.shirtRemove.Text = "Remove";
            this.shirtRemove.UseVisualStyleBackColor = true;
            this.shirtRemove.Visible = false;
            this.shirtRemove.Click += new System.EventHandler(this.shirtRemove_Click);
            // 
            // shirtCounter
            // 
            this.shirtCounter.AutoSize = true;
            this.shirtCounter.Location = new System.Drawing.Point(555, 121);
            this.shirtCounter.Name = "shirtCounter";
            this.shirtCounter.Size = new System.Drawing.Size(14, 16);
            this.shirtCounter.TabIndex = 13;
            this.shirtCounter.Text = "5";
            this.shirtCounter.Visible = false;
            // 
            // hatCounter
            // 
            this.hatCounter.AutoSize = true;
            this.hatCounter.Location = new System.Drawing.Point(555, 179);
            this.hatCounter.Name = "hatCounter";
            this.hatCounter.Size = new System.Drawing.Size(14, 16);
            this.hatCounter.TabIndex = 14;
            this.hatCounter.Text = "5";
            this.hatCounter.Visible = false;
            // 
            // shoeCounter
            // 
            this.shoeCounter.AutoSize = true;
            this.shoeCounter.Location = new System.Drawing.Point(555, 150);
            this.shoeCounter.Name = "shoeCounter";
            this.shoeCounter.Size = new System.Drawing.Size(14, 16);
            this.shoeCounter.TabIndex = 15;
            this.shoeCounter.Text = "5";
            this.shoeCounter.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(461, 223);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 23);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close Menu";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.shoeCounter);
            this.Controls.Add(this.hatCounter);
            this.Controls.Add(this.shirtCounter);
            this.Controls.Add(this.hatRemove);
            this.Controls.Add(this.shoesRemove);
            this.Controls.Add(this.shirtRemove);
            this.Controls.Add(this.hat);
            this.Controls.Add(this.shoes);
            this.Controls.Add(this.shirt);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Button shirt;
        private System.Windows.Forms.Button shoes;
        private System.Windows.Forms.Button hat;
        private System.Windows.Forms.Button hatRemove;
        private System.Windows.Forms.Button shoesRemove;
        private System.Windows.Forms.Button shirtRemove;
        private System.Windows.Forms.Label shirtCounter;
        private System.Windows.Forms.Label hatCounter;
        private System.Windows.Forms.Label shoeCounter;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

