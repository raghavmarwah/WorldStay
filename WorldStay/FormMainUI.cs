using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldStay
{
    public partial class FormMainUI : Form
    {
        DatabaseAccess dbAccess = new DatabaseAccess();
        
        //global list to store display data
        List<DisplayData> dataList = new List<DisplayData>();

        public FormMainUI()
        {
            InitializeComponent();

            //registering event handlers
            comboBoxOrderBy.SelectedIndexChanged += ComboBoxOrderBy_SelectedIndexChanged;
            comboBoxRoomType.SelectedIndexChanged += ComboBoxRoomType_SelectedIndexChanged;
            comboBoxNumBedrooms.SelectedIndexChanged += ComboBoxNumBedrooms_SelectedIndexChanged;
            comboBoxNumBathrooms.SelectedIndexChanged += ComboBoxNumBathrooms_SelectedIndexChanged;
            textBoxNameSearchString.TextChanged += TextBoxNameSearchString_TextChanged;
        }

        private void ComboBoxNumBathrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridViewSuites();
        }

        private void ComboBoxNumBedrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridViewSuites();
        }

        private void TextBoxNameSearchString_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridViewSuites();
        }

        private void ComboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridViewSuites();
        }

        private void ComboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridViewSuites();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 590;
            this.Width = 1079;
            InitializeDataGridView();
            FeedDataToDataGridView();
            comboBoxOrderBy.SelectedIndex= 0;
            
            dbAccess.OpenConnection();
            List<String> roomTypes = dbAccess.GetRoomTypes();
            List<int> NumberOfBedrooms = dbAccess.GetNumberOfBedrooms();
            List<int> NumberOfBathrooms = dbAccess.GetNumberOfBathrooms();
            dbAccess.CloseConnection();

            //filling data in comboBoxRoomTypes
            comboBoxRoomType.Items.Add("All");
            foreach (String roomType in roomTypes)
                comboBoxRoomType.Items.Add(roomType);
            comboBoxRoomType.SelectedIndex = 0;

            //filling data in comboBoxNumBedrooms
            comboBoxNumBedrooms.Items.Add("All");
            foreach (int bedrooms in NumberOfBedrooms)
                comboBoxNumBedrooms.Items.Add(bedrooms.ToString());
            comboBoxNumBedrooms.SelectedIndex = 0;

            //filling data in comboBoxNumBathrooms
            comboBoxNumBathrooms.Items.Add("All");
            foreach (int bathrooms in NumberOfBathrooms)
                comboBoxNumBathrooms.Items.Add(bathrooms.ToString());
            comboBoxNumBathrooms.SelectedIndex = 0;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideAllNavIndicatorsAndPanels()
        {
            //Hiding nav indicator panels
            navIndicatorSearch.Visible = false;
            navIndicatorFavourites.Visible = false;
            navIndicatorCheckout.Visible = false;
            navIndicatorProfile.Visible = false;

            //Hiding MainUI Panels
            panelSearch.Visible = false;
            panelFavourites.Visible = false;
            panelCheckout.Visible = false;
            panelProfile.Visible = false;
        }

        private void buttonNavSearch_Click(object sender, EventArgs e)
        {
            HideAllNavIndicatorsAndPanels();
            navIndicatorSearch.Visible = true;
            panelSearch.Visible = true;
        }

        private void buttonNavFavourites_Click(object sender, EventArgs e)
        {
            HideAllNavIndicatorsAndPanels();
            navIndicatorFavourites.Visible = true;
            panelFavourites.Visible = true;
        }

        private void buttonNavCheckout_Click(object sender, EventArgs e)
        {
            HideAllNavIndicatorsAndPanels();
            navIndicatorCheckout.Visible = true;
            panelCheckout.Visible = true;
        }

        private void buttonNavProfile_Click(object sender, EventArgs e)
        {
            HideAllNavIndicatorsAndPanels();
            navIndicatorProfile.Visible = true;
            panelProfile.Visible = true;
        }

        private void buttonReseedData_Click(object sender, EventArgs e)
        {
            try
            {
                //connecting to the database
                dbAccess.OpenConnection();

                //clearing previous data from tables
                dbAccess.TruncateData("Countries");
                dbAccess.TruncateData("Hotels");
                dbAccess.TruncateData("Suites");


                String tempLine = "";

                //seeding dbo.Countries
                StreamReader countriesFile = File.OpenText("Countries.dat");
                while (!countriesFile.EndOfStream)
                {
                    tempLine = countriesFile.ReadLine();
                    dbAccess.InsertCountry(new Country {
                        CountryName = tempLine
                    });
                }
                countriesFile.Close();

                //seeding dbo.Hotels
                StreamReader hotelsFile = File.OpenText("Hotels.dat");
                while (!hotelsFile.EndOfStream)
                {
                    tempLine = hotelsFile.ReadLine();
                    String[] splitData = tempLine.Split(',');
                    dbAccess.InsertHotel(new Hotel
                    {
                        HotelName = splitData[0],
                        CountryId = int.Parse(splitData[1])

                    });
                }
                countriesFile.Close();

                //seeding dbo.Suites
                StreamReader suitesFile = File.OpenText("Suites.dat");
                while (!suitesFile.EndOfStream)
                {
                    tempLine = suitesFile.ReadLine();
                    String[] splitData = tempLine.Split(',');
                    dbAccess.InsertSuite(new Suite
                    {
                        RoomNumber = splitData[0],
                        Floor = splitData[1],
                        RoomType = splitData[2],
                        NumberOfBedrooms = int.Parse(splitData[3]),
                        NumberOfBathrooms  = int.Parse(splitData[4]),
                        NightlyRate = int.Parse(splitData[5]),
                        IsAvailable = true,
                        ThumbnailURL = splitData[6],
                        HotelId = int.Parse(splitData[7])

                    });
                }
                countriesFile.Close();

                //disconnecting from the database
                dbAccess.CloseConnection();

                //Re-feeding data to dataGridViewSuites
                FeedDataToDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This method initializes the dataGridViewSuites
        /// </summary>
        private void InitializeDataGridView()
        {
            //setting attributes
            dataGridViewSuites.ReadOnly = true;
            dataGridViewSuites.AllowUserToAddRows = false;
            dataGridViewSuites.AllowUserToDeleteRows = false;
            dataGridViewSuites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewSuites.RowHeadersWidth = 40;
            dataGridViewSuites.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewSuites.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Defining columns to add to the DataGridView
            //Imp DataGridViewTextBOoxColumn not DataGridViewColumn
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() {Name = "Hotel Name" },
                new DataGridViewTextBoxColumn() { Name = "Room Type" },
                new DataGridViewTextBoxColumn() { Name = "Room Number" },
                new DataGridViewTextBoxColumn() { Name = "Bedrooms" },
                new DataGridViewTextBoxColumn() { Name = "Bathrooms" },
                new DataGridViewTextBoxColumn() { Name = "Nightly Rate" },
                new DataGridViewTextBoxColumn() { Name = "Country" }
                };

            dataGridViewSuites.Columns.Clear();
            dataGridViewSuites.Columns.AddRange(columns);

        }

        /// <summary>
        /// Adds the data to dataGridViewSuites
        /// </summary>
        private void FeedDataToDataGridView()
        {
            dbAccess.OpenConnection();
            dataList = dbAccess.GetSuites();
            dbAccess.CloseConnection();

            var dataOrderQuery = dataList
                .OrderBy(p => p.Country)
                .Select(p => p);

            dataGridViewSuites.Rows.Clear();
            foreach (DisplayData p in dataOrderQuery)
            {
                dataGridViewSuites.Rows.Add(p.HotelName, p.RoomType, p.RoomNumber, p.NumBedrooms, p.NumBathrooms, p.NightlyRate, p.Country);
            }
        }

        private void UpdateDataGridViewSuites()
        {
            List<DisplayData> filterData = dataList;

            //textBoxNameSearchString
            if (textBoxNameSearchString.Text.Length > 0)
                filterData = filterData.Where(p => p.HotelName.ToLower().Contains(textBoxNameSearchString.Text.ToLower())).Select(p => p).ToList();

            //comboBoxRoomType
            if (comboBoxRoomType.SelectedIndex != 0)
                filterData = filterData.Where(p => p.RoomType.Equals(comboBoxRoomType.SelectedItem)).Select(p => p).ToList();

            //comboBoxNumBedrooms
            if (comboBoxNumBedrooms.SelectedIndex != 0)
                filterData = filterData.Where(p => p.NumBedrooms.ToString().Equals(comboBoxNumBedrooms.SelectedItem)).Select(p => p).ToList();

            //comboBoxNumBathrooms
            if (comboBoxNumBathrooms.SelectedIndex != 0)
                filterData = filterData.Where(p => p.NumBathrooms.ToString().Equals(comboBoxNumBathrooms.SelectedItem)).Select(p => p).ToList();

            //comboBoxOrderby
            if (comboBoxOrderBy.SelectedIndex == 0)
                filterData = filterData.OrderBy(p => p.Country).Select(p => p).ToList();
            else if (comboBoxOrderBy.SelectedIndex == 1)
                filterData = filterData.OrderBy(p => p.NightlyRate).Select(p => p).ToList();
            else if (comboBoxOrderBy.SelectedIndex == 2)
                filterData = filterData.OrderByDescending(p => p.NightlyRate).Select(p => p).ToList();
            
            dataGridViewSuites.Rows.Clear();
            foreach (DisplayData p in filterData)
            {
                dataGridViewSuites.Rows.Add(p.HotelName, p.RoomType, p.RoomNumber, p.NumBedrooms, p.NumBathrooms, p.NightlyRate, p.Country);
            }

        }
    }
}
