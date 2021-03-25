namespace WebScraperConsole
{
    partial class WebScraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebScraper));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.ExtractBtn = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.PictureBox();
            this.SupriseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.SaveBtn.Location = new System.Drawing.Point(769, 521);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 25);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save Images";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.ButtonSaveImages_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UrlBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlBox.Location = new System.Drawing.Point(0, 202);
            this.UrlBox.Margin = new System.Windows.Forms.Padding(4);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(902, 25);
            this.UrlBox.TabIndex = 1;
            this.UrlBox.Text = "https://gp.se";
            this.UrlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            // 
            // ExtractBtn
            // 
            this.ExtractBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtractBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ExtractBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExtractBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.ExtractBtn.Location = new System.Drawing.Point(527, 521);
            this.ExtractBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExtractBtn.Name = "ExtractBtn";
            this.ExtractBtn.Size = new System.Drawing.Size(117, 25);
            this.ExtractBtn.TabIndex = 2;
            this.ExtractBtn.Text = "Extract";
            this.ExtractBtn.UseVisualStyleBackColor = false;
            this.ExtractBtn.Click += new System.EventHandler(this.ButtonExtractImageURLS_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NumberBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.NumberBox.Location = new System.Drawing.Point(-4, 474);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(894, 27);
            this.NumberBox.TabIndex = 4;
            this.NumberBox.Click += new System.EventHandler(this.NumberBox_Click);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(-4, 235);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(894, 235);
            this.TextBox.TabIndex = 5;
            this.TextBox.Text = "Loading...";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Background
            // 
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(-26, -15);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(960, 615);
            this.Background.TabIndex = 6;
            this.Background.TabStop = false;
            // 
            // Header
            // 
            this.Header.Image = ((System.Drawing.Image)(resources.GetObject("Header.Image")));
            this.Header.Location = new System.Drawing.Point(-4, 1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(894, 226);
            this.Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Header.TabIndex = 7;
            this.Header.TabStop = false;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // SupriseBtn
            // 
            this.SupriseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SupriseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SupriseBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F);
            this.SupriseBtn.Location = new System.Drawing.Point(652, 521);
            this.SupriseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SupriseBtn.Name = "SupriseBtn";
            this.SupriseBtn.Size = new System.Drawing.Size(109, 25);
            this.SupriseBtn.TabIndex = 8;
            this.SupriseBtn.Text = "Suprise Me";
            this.SupriseBtn.UseVisualStyleBackColor = true;
            this.SupriseBtn.Click += new System.EventHandler(this.SupriseBtn_Click);
            // 
            // WebScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 559);
            this.Controls.Add(this.SupriseBtn);
            this.Controls.Add(this.ExtractBtn);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebScraper";
            this.Text = "Web Scraper";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Button ExtractBtn;
        private System.Windows.Forms.Label NumberBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.Button SupriseBtn;
    }
}

