namespace WorldStay
{
    partial class FormMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUI));
            this.panelLeftNavigation = new System.Windows.Forms.Panel();
            this.navIndicatorProfile = new System.Windows.Forms.Panel();
            this.navIndicatorCheckout = new System.Windows.Forms.Panel();
            this.navIndicatorFavourites = new System.Windows.Forms.Panel();
            this.navIndicatorSearch = new System.Windows.Forms.Panel();
            this.buttonNavProfile = new System.Windows.Forms.Button();
            this.buttonNavCheckout = new System.Windows.Forms.Button();
            this.buttonNavFavourites = new System.Windows.Forms.Button();
            this.buttonNavSearch = new System.Windows.Forms.Button();
            this.panelTopStrip = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxTopLogo = new System.Windows.Forms.PictureBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.pictureBoxSmallLogo = new System.Windows.Forms.PictureBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.comboBoxNumBathrooms = new System.Windows.Forms.ComboBox();
            this.comboBoxNumBedrooms = new System.Windows.Forms.ComboBox();
            this.labelNumBathrooms = new System.Windows.Forms.Label();
            this.labelNumBedrooms = new System.Windows.Forms.Label();
            this.textBoxNameSearchString = new System.Windows.Forms.TextBox();
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.dataGridViewSuites = new System.Windows.Forms.DataGridView();
            this.panelFavourites = new System.Windows.Forms.Panel();
            this.panelCheckout = new System.Windows.Forms.Panel();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.buttonReseedData = new System.Windows.Forms.Button();
            this.buttonViewSuite = new System.Windows.Forms.Button();
            this.panelLeftNavigation.SuspendLayout();
            this.panelTopStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuites)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftNavigation
            // 
            this.panelLeftNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.panelLeftNavigation.Controls.Add(this.navIndicatorProfile);
            this.panelLeftNavigation.Controls.Add(this.navIndicatorCheckout);
            this.panelLeftNavigation.Controls.Add(this.navIndicatorFavourites);
            this.panelLeftNavigation.Controls.Add(this.navIndicatorSearch);
            this.panelLeftNavigation.Controls.Add(this.buttonNavProfile);
            this.panelLeftNavigation.Controls.Add(this.buttonNavCheckout);
            this.panelLeftNavigation.Controls.Add(this.buttonNavFavourites);
            this.panelLeftNavigation.Controls.Add(this.buttonNavSearch);
            this.panelLeftNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigation.Name = "panelLeftNavigation";
            this.panelLeftNavigation.Size = new System.Drawing.Size(411, 1135);
            this.panelLeftNavigation.TabIndex = 0;
            // 
            // navIndicatorProfile
            // 
            this.navIndicatorProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.navIndicatorProfile.Location = new System.Drawing.Point(-3, 640);
            this.navIndicatorProfile.Name = "navIndicatorProfile";
            this.navIndicatorProfile.Size = new System.Drawing.Size(39, 93);
            this.navIndicatorProfile.TabIndex = 6;
            this.navIndicatorProfile.Visible = false;
            // 
            // navIndicatorCheckout
            // 
            this.navIndicatorCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.navIndicatorCheckout.Location = new System.Drawing.Point(-3, 511);
            this.navIndicatorCheckout.Name = "navIndicatorCheckout";
            this.navIndicatorCheckout.Size = new System.Drawing.Size(39, 93);
            this.navIndicatorCheckout.TabIndex = 6;
            this.navIndicatorCheckout.Visible = false;
            // 
            // navIndicatorFavourites
            // 
            this.navIndicatorFavourites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.navIndicatorFavourites.Location = new System.Drawing.Point(-3, 382);
            this.navIndicatorFavourites.Name = "navIndicatorFavourites";
            this.navIndicatorFavourites.Size = new System.Drawing.Size(39, 93);
            this.navIndicatorFavourites.TabIndex = 6;
            this.navIndicatorFavourites.Visible = false;
            // 
            // navIndicatorSearch
            // 
            this.navIndicatorSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.navIndicatorSearch.Location = new System.Drawing.Point(-3, 253);
            this.navIndicatorSearch.Name = "navIndicatorSearch";
            this.navIndicatorSearch.Size = new System.Drawing.Size(39, 93);
            this.navIndicatorSearch.TabIndex = 6;
            // 
            // buttonNavProfile
            // 
            this.buttonNavProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavProfile.FlatAppearance.BorderSize = 0;
            this.buttonNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavProfile.ForeColor = System.Drawing.Color.White;
            this.buttonNavProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavProfile.Image")));
            this.buttonNavProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavProfile.Location = new System.Drawing.Point(42, 640);
            this.buttonNavProfile.Name = "buttonNavProfile";
            this.buttonNavProfile.Size = new System.Drawing.Size(369, 93);
            this.buttonNavProfile.TabIndex = 4;
            this.buttonNavProfile.Text = "  Profile";
            this.buttonNavProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNavProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavProfile.UseVisualStyleBackColor = true;
            this.buttonNavProfile.Click += new System.EventHandler(this.buttonNavProfile_Click);
            // 
            // buttonNavCheckout
            // 
            this.buttonNavCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavCheckout.FlatAppearance.BorderSize = 0;
            this.buttonNavCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavCheckout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavCheckout.ForeColor = System.Drawing.Color.White;
            this.buttonNavCheckout.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavCheckout.Image")));
            this.buttonNavCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavCheckout.Location = new System.Drawing.Point(42, 511);
            this.buttonNavCheckout.Name = "buttonNavCheckout";
            this.buttonNavCheckout.Size = new System.Drawing.Size(369, 93);
            this.buttonNavCheckout.TabIndex = 3;
            this.buttonNavCheckout.Text = "  Checkout";
            this.buttonNavCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNavCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavCheckout.UseVisualStyleBackColor = true;
            this.buttonNavCheckout.Click += new System.EventHandler(this.buttonNavCheckout_Click);
            // 
            // buttonNavFavourites
            // 
            this.buttonNavFavourites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavFavourites.FlatAppearance.BorderSize = 0;
            this.buttonNavFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavFavourites.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavFavourites.ForeColor = System.Drawing.Color.White;
            this.buttonNavFavourites.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavFavourites.Image")));
            this.buttonNavFavourites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavFavourites.Location = new System.Drawing.Point(42, 382);
            this.buttonNavFavourites.Name = "buttonNavFavourites";
            this.buttonNavFavourites.Size = new System.Drawing.Size(369, 93);
            this.buttonNavFavourites.TabIndex = 2;
            this.buttonNavFavourites.Text = "  Favourites";
            this.buttonNavFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNavFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavFavourites.UseVisualStyleBackColor = true;
            this.buttonNavFavourites.Click += new System.EventHandler(this.buttonNavFavourites_Click);
            // 
            // buttonNavSearch
            // 
            this.buttonNavSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavSearch.FlatAppearance.BorderSize = 0;
            this.buttonNavSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavSearch.ForeColor = System.Drawing.Color.White;
            this.buttonNavSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavSearch.Image")));
            this.buttonNavSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavSearch.Location = new System.Drawing.Point(42, 253);
            this.buttonNavSearch.Name = "buttonNavSearch";
            this.buttonNavSearch.Size = new System.Drawing.Size(369, 93);
            this.buttonNavSearch.TabIndex = 1;
            this.buttonNavSearch.Text = "  Search";
            this.buttonNavSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNavSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavSearch.UseVisualStyleBackColor = true;
            this.buttonNavSearch.Click += new System.EventHandler(this.buttonNavSearch_Click);
            // 
            // panelTopStrip
            // 
            this.panelTopStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.panelTopStrip.Controls.Add(this.panel3);
            this.panelTopStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopStrip.Location = new System.Drawing.Point(411, 0);
            this.panelTopStrip.Name = "panelTopStrip";
            this.panelTopStrip.Size = new System.Drawing.Size(1746, 20);
            this.panelTopStrip.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(89, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 132);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.panel4.Controls.Add(this.pictureBoxTopLogo);
            this.panel4.Location = new System.Drawing.Point(411, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 73);
            this.panel4.TabIndex = 2;
            // 
            // pictureBoxTopLogo
            // 
            this.pictureBoxTopLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopLogo.Image")));
            this.pictureBoxTopLogo.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxTopLogo.Name = "pictureBoxTopLogo";
            this.pictureBoxTopLogo.Size = new System.Drawing.Size(290, 55);
            this.pictureBoxTopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTopLogo.TabIndex = 0;
            this.pictureBoxTopLogo.TabStop = false;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.Color.White;
            this.buttonCloseForm.Location = new System.Drawing.Point(2099, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(58, 52);
            this.buttonCloseForm.TabIndex = 3;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // pictureBoxSmallLogo
            // 
            this.pictureBoxSmallLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSmallLogo.Image")));
            this.pictureBoxSmallLogo.Location = new System.Drawing.Point(2012, 1034);
            this.pictureBoxSmallLogo.Name = "pictureBoxSmallLogo";
            this.pictureBoxSmallLogo.Size = new System.Drawing.Size(145, 102);
            this.pictureBoxSmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSmallLogo.TabIndex = 4;
            this.pictureBoxSmallLogo.TabStop = false;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.buttonClearFilters);
            this.panelSearch.Controls.Add(this.comboBoxNumBathrooms);
            this.panelSearch.Controls.Add(this.comboBoxNumBedrooms);
            this.panelSearch.Controls.Add(this.labelNumBathrooms);
            this.panelSearch.Controls.Add(this.labelNumBedrooms);
            this.panelSearch.Controls.Add(this.textBoxNameSearchString);
            this.panelSearch.Controls.Add(this.labelSearchByName);
            this.panelSearch.Controls.Add(this.comboBoxRoomType);
            this.panelSearch.Controls.Add(this.labelRoomType);
            this.panelSearch.Controls.Add(this.comboBoxOrderBy);
            this.panelSearch.Controls.Add(this.labelOrderBy);
            this.panelSearch.Controls.Add(this.dataGridViewSuites);
            this.panelSearch.Location = new System.Drawing.Point(417, 79);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1595, 1056);
            this.panelSearch.TabIndex = 5;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilters.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFilters.ForeColor = System.Drawing.Color.White;
            this.buttonClearFilters.Location = new System.Drawing.Point(1335, 872);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(199, 86);
            this.buttonClearFilters.TabIndex = 11;
            this.buttonClearFilters.Text = "Clear Filters";
            this.buttonClearFilters.UseVisualStyleBackColor = false;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // comboBoxNumBathrooms
            // 
            this.comboBoxNumBathrooms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumBathrooms.FormattingEnabled = true;
            this.comboBoxNumBathrooms.Location = new System.Drawing.Point(1147, 938);
            this.comboBoxNumBathrooms.Name = "comboBoxNumBathrooms";
            this.comboBoxNumBathrooms.Size = new System.Drawing.Size(115, 35);
            this.comboBoxNumBathrooms.TabIndex = 10;
            // 
            // comboBoxNumBedrooms
            // 
            this.comboBoxNumBedrooms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumBedrooms.FormattingEnabled = true;
            this.comboBoxNumBedrooms.Location = new System.Drawing.Point(836, 938);
            this.comboBoxNumBedrooms.Name = "comboBoxNumBedrooms";
            this.comboBoxNumBedrooms.Size = new System.Drawing.Size(115, 35);
            this.comboBoxNumBedrooms.TabIndex = 9;
            // 
            // labelNumBathrooms
            // 
            this.labelNumBathrooms.AutoSize = true;
            this.labelNumBathrooms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumBathrooms.Location = new System.Drawing.Point(999, 941);
            this.labelNumBathrooms.Name = "labelNumBathrooms";
            this.labelNumBathrooms.Size = new System.Drawing.Size(142, 27);
            this.labelNumBathrooms.TabIndex = 8;
            this.labelNumBathrooms.Text = "Bathrooms: ";
            // 
            // labelNumBedrooms
            // 
            this.labelNumBedrooms.AutoSize = true;
            this.labelNumBedrooms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumBedrooms.Location = new System.Drawing.Point(689, 941);
            this.labelNumBedrooms.Name = "labelNumBedrooms";
            this.labelNumBedrooms.Size = new System.Drawing.Size(135, 27);
            this.labelNumBedrooms.TabIndex = 7;
            this.labelNumBedrooms.Text = "Bedrooms: ";
            // 
            // textBoxNameSearchString
            // 
            this.textBoxNameSearchString.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameSearchString.Location = new System.Drawing.Point(139, 855);
            this.textBoxNameSearchString.Name = "textBoxNameSearchString";
            this.textBoxNameSearchString.Size = new System.Drawing.Size(459, 35);
            this.textBoxNameSearchString.TabIndex = 6;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchByName.Location = new System.Drawing.Point(12, 858);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(95, 27);
            this.labelSearchByName.TabIndex = 5;
            this.labelSearchByName.Text = "Search:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(836, 855);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(426, 35);
            this.comboBoxRoomType.TabIndex = 4;
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(689, 858);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(141, 27);
            this.labelRoomType.TabIndex = 3;
            this.labelRoomType.Text = "Room Type:";
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Items.AddRange(new object[] {
            "Country",
            "Price (Low to High)",
            "Price (High to Low)"});
            this.comboBoxOrderBy.Location = new System.Drawing.Point(139, 941);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(459, 35);
            this.comboBoxOrderBy.TabIndex = 2;
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderBy.Location = new System.Drawing.Point(12, 941);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(116, 27);
            this.labelOrderBy.TabIndex = 1;
            this.labelOrderBy.Text = "Order By:";
            // 
            // dataGridViewSuites
            // 
            this.dataGridViewSuites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuites.Location = new System.Drawing.Point(17, 20);
            this.dataGridViewSuites.Name = "dataGridViewSuites";
            this.dataGridViewSuites.RowTemplate.Height = 33;
            this.dataGridViewSuites.Size = new System.Drawing.Size(1551, 770);
            this.dataGridViewSuites.TabIndex = 0;
            // 
            // panelFavourites
            // 
            this.panelFavourites.BackColor = System.Drawing.Color.White;
            this.panelFavourites.Location = new System.Drawing.Point(417, 79);
            this.panelFavourites.Name = "panelFavourites";
            this.panelFavourites.Size = new System.Drawing.Size(1595, 1056);
            this.panelFavourites.TabIndex = 1;
            // 
            // panelCheckout
            // 
            this.panelCheckout.BackColor = System.Drawing.Color.White;
            this.panelCheckout.Location = new System.Drawing.Point(417, 79);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(1595, 1056);
            this.panelCheckout.TabIndex = 1;
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.White;
            this.panelProfile.Location = new System.Drawing.Point(417, 79);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(1595, 1056);
            this.panelProfile.TabIndex = 1;
            // 
            // buttonReseedData
            // 
            this.buttonReseedData.Location = new System.Drawing.Point(2035, 966);
            this.buttonReseedData.Name = "buttonReseedData";
            this.buttonReseedData.Size = new System.Drawing.Size(110, 62);
            this.buttonReseedData.TabIndex = 6;
            this.buttonReseedData.Text = "Reseed";
            this.buttonReseedData.UseVisualStyleBackColor = true;
            this.buttonReseedData.Visible = false;
            this.buttonReseedData.Click += new System.EventHandler(this.buttonReseedData_Click);
            // 
            // buttonViewSuite
            // 
            this.buttonViewSuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonViewSuite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewSuite.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Bold);
            this.buttonViewSuite.ForeColor = System.Drawing.Color.White;
            this.buttonViewSuite.Location = new System.Drawing.Point(2012, 799);
            this.buttonViewSuite.Name = "buttonViewSuite";
            this.buttonViewSuite.Size = new System.Drawing.Size(119, 70);
            this.buttonViewSuite.TabIndex = 7;
            this.buttonViewSuite.Text = "View>";
            this.buttonViewSuite.UseVisualStyleBackColor = false;
            // 
            // FormMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2157, 1135);
            this.Controls.Add(this.buttonViewSuite);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.buttonReseedData);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelCheckout);
            this.Controls.Add(this.panelFavourites);
            this.Controls.Add(this.pictureBoxSmallLogo);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelTopStrip);
            this.Controls.Add(this.panelLeftNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeftNavigation.ResumeLayout(false);
            this.panelTopStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftNavigation;
        private System.Windows.Forms.Panel panelTopStrip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxTopLogo;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonNavProfile;
        private System.Windows.Forms.Button buttonNavCheckout;
        private System.Windows.Forms.Button buttonNavFavourites;
        private System.Windows.Forms.Button buttonNavSearch;
        private System.Windows.Forms.PictureBox pictureBoxSmallLogo;
        private System.Windows.Forms.Panel navIndicatorProfile;
        private System.Windows.Forms.Panel navIndicatorCheckout;
        private System.Windows.Forms.Panel navIndicatorFavourites;
        private System.Windows.Forms.Panel navIndicatorSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelFavourites;
        private System.Windows.Forms.Panel panelCheckout;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button buttonReseedData;
        private System.Windows.Forms.DataGridView dataGridViewSuites;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.TextBox textBoxNameSearchString;
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.ComboBox comboBoxNumBathrooms;
        private System.Windows.Forms.ComboBox comboBoxNumBedrooms;
        private System.Windows.Forms.Label labelNumBathrooms;
        private System.Windows.Forms.Label labelNumBedrooms;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonViewSuite;
    }
}

