using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Interfaces;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }
        //List<String> prizeTypes = new List<String> {"item","money","voucher"};

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //prizeTypeDropDown.DataSource = prizeTypes;

            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNumberValue.Text, prizeAmountValue.Text, prizePercentageValue.Text);
                

                model.PrizeName = prizeNameValue.Text;
                //model.PrizeType = prizeTypeDropDown.GetItemText(prizeTypeDropDown);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                prizeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";

            }
            else MessageBox.Show("Form is invalid.");

        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns>Form validation.</returns>
        private bool ValidateForm()
        {
            bool output = true;

            if (prizeNameValue.Text.Length == 0)
            {
                output = false;
            }

            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValid)
            {
                output = false;
            }

            if(placeNumber < 1)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);

            if (!prizeAmountValid)
            {
                output = false;
            }

            if(prizeAmount < 0)
            {
                output = false;
            }

            //bool prizeTypeValid = prizeTypes.Contains(prizeTypeDropDown.GetItemText(prizeTypeDropDown));

            /*if (!prizeTypeValid)
            {
                output = false;
            }*/

            double prizePercentage = 0;
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizePercentageValid)
            {
                output = false;
            }

            if (prizePercentage <= 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
