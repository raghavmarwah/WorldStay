using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldStay
{
    public partial class FormDisplaySuite : Form
    {
        DatabaseAccess dbAccess = new DatabaseAccess();
        int selectedSuiteId;
        int userId;

        //selected suite global object
        DisplayData selectedSuite;

        //bool checking if the suite is in favourites.
        bool inFavourties;

        public FormDisplaySuite(int suiteId, int userId)
        {
            InitializeComponent();
            selectedSuiteId = suiteId;
            this.userId = userId;

            this.Height = 600;
            buttonBookNow.FlatAppearance.BorderSize = 0;
            buttonAddToFavourites.FlatAppearance.BorderSize = 0;

            dbAccess.OpenConnection();
            selectedSuite = dbAccess.GetSuites(suiteId)[0];
            dbAccess.CloseConnection();
        }

        private void FormDisplaySuite_Load(object sender, EventArgs e)
        {
            int lastDigit;
            if (selectedSuiteId < 10)
                lastDigit = selectedSuiteId;
            else
                lastDigit = selectedSuiteId % 10;

            pictureBoxSuiteImage.Image = Image.FromFile("suite"+lastDigit+".jpg");

            //getting data from the passed object
            labelHotelNameValue.Text = selectedSuite.HotelName;
            labelRoomTypeValue.Text = selectedSuite.RoomType;
            labelRoomNumberValue.Text = selectedSuite.RoomNumber;
            labelNumBedroomsValue.Text = selectedSuite.NumBedrooms.ToString();
            labelNumBathroomsValue.Text = selectedSuite.NumBathrooms.ToString();
            labelCountryValue.Text = selectedSuite.Country;
            labelNightlyRate.Text = selectedSuite.NightlyRate.ToString("c2") + " / night";

            toolTip.SetToolTip(buttonAddToFavourites, "Add To Favourites!");
            //checking if the suite is a favourite
            dbAccess.OpenConnection();
            inFavourties = dbAccess.CheckInFavourites(new Favourite
            {
                UserId = userId,
                SuiteId = selectedSuiteId
            });
            dbAccess.CloseConnection();
            ChangeFavouriteIcon(inFavourties);

        }

        

        private void buttonBookNow_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToFavourites_Click(object sender, EventArgs e)
        {
            Favourite currentSuite = new Favourite
            {
                UserId = userId,
                SuiteId = selectedSuiteId
            };


            dbAccess.OpenConnection();
            inFavourties = dbAccess.CheckInFavourites(new Favourite
            {
                UserId = userId,
                SuiteId = selectedSuiteId
            });
            dbAccess.CloseConnection();

            if (inFavourties)
            {
                dbAccess.OpenConnection();
                dbAccess.RemoveFromFavourites(currentSuite);
                ChangeFavouriteIcon(false);
                dbAccess.CloseConnection();
            }
            else
            {
                dbAccess.OpenConnection();
                dbAccess.AddToFavourites(currentSuite);
                ChangeFavouriteIcon(true);    
                dbAccess.CloseConnection();
            }
        }

        private void ChangeFavouriteIcon(bool test)
        {
            if (test)
                buttonAddToFavourites.BackgroundImage = Image.FromFile("favourite.png");
            else
                buttonAddToFavourites.BackgroundImage = Image.FromFile("notfavourite.png");
        }
    }
}
