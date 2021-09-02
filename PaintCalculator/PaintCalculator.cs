using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintCalculator
{
    public partial class PaintCalculator : Form
    {
        //variables that will be used

        //what type of measurement will be used
        private string measurement;
        //if the labels should appear or not
        private bool labels;

        public PaintCalculator()
        {
            InitializeComponent();
        }

        private void MeasurementChanged()
        {
            //clear the form
            txtWidth.Clear();
            txtHeight.Clear();
            txtLength.Clear();
            txtWidthInches.Text = "0";
            txtHeightInches.Text = "0";
            txtLengthInches.Text = "0";

            //change the measurement and if the labels should appear
            if (rdoFeetInches.Checked == true)
            {
                measurement = "ft";
                labels = true;
                grpDisplayUnits.Visible = true;
            }
            else if (rdoCentimeters.Checked == true)
            {
                measurement = "cm";
                labels = false;
                grpDisplayUnits.Visible = false;
            }
            else if (rdoMeters.Checked == true)
            {
                measurement = "m";
                labels = false;
                grpDisplayUnits.Visible = false;
            }

            //change the measurements on the labels
            lblWidthMeasurement.Text = measurement;
            lblHeightMeasurement.Text = measurement;
            lblLengthMeasurement.Text = measurement;

            //change the visibility of the boxes and labels
            txtWidthInches.Visible = labels;
            txtHeightInches.Visible = labels;
            txtLengthInches.Visible = labels;
            lblWidthInches.Visible = labels;
            lblHeightInches.Visible = labels;
            lblLengthInches.Visible = labels;
        }

        //run the measurement changed method
        private void rdoCentimeters_CheckedChanged(object sender, EventArgs e)
        {
            MeasurementChanged();
        }

        private void rdoMeters_CheckedChanged(object sender, EventArgs e)
        {
            MeasurementChanged();
        }

        private void rdoFeetInches_CheckedChanged(object sender, EventArgs e)
        {
            MeasurementChanged();
        }




        private void btnConfirm_Click(object sender, EventArgs e)
        {

            Room room = new Room();

            try
            {
                room.Coats = (int)nupCoats.Value;
                room.Measurement = measurement;

                if (rdoFeetInches.Checked == true)
                {

                    //convert feet and inches to inches and assign to class
                    room.Length = (decimal.Parse(txtLength.Text) * 12) + decimal.Parse(txtLengthInches.Text);
                    room.Width = (decimal.Parse(txtWidth.Text) * 12) + decimal.Parse(txtWidthInches.Text);
                    room.Height = (decimal.Parse(txtHeight.Text) * 12) + decimal.Parse(txtHeightInches.Text);

                    //convert the inches into feet
                    float squarefeet = (float)(room.FloorArea / 144);
                    float volumeFeet = (float)(room.RoomVolume / 1728);

                    //Change display units depending on which selected
                    if (rdoDisplayFeet.Checked == true)
                    {
                        //display the converted values
                        //convert to float to shorted amount of decimal numbers
                        txtFloorArea.Text = ((float)squarefeet).ToString() + " Ft² ";
                        txtRoomVolume.Text = ((float)volumeFeet).ToString() + " Ft³";
                    }
                    else if (rdoDisplayInches.Checked == true)
                    {
                        //display the values that are already in inches
                        txtFloorArea.Text = ((float)room.FloorArea).ToString() + " In²";
                        txtRoomVolume.Text = ((float)room.RoomVolume).ToString() + " In³";
                    }
                    else if (rdoDisplayFeetInches.Checked == true)
                    {
                        //feet + remaining inches
                        txtFloorArea.Text = ((int)squarefeet) + " Ft² " + ((float)room.FloorArea % 144) + " In²";
                        txtRoomVolume.Text = ((int)volumeFeet) + " Ft³" + ((float)room.RoomVolume % 1728) + " In³";
                    }


                }
                else
                {

                    //take the input from the user as it is
                    room.Length = decimal.Parse(txtLength.Text);
                    room.Width = decimal.Parse(txtWidth.Text);
                    room.Height = decimal.Parse(txtHeight.Text);

                    txtRoomVolume.Text = room.RoomVolume.ToString() + " " + room.Measurement + "³";
                    txtFloorArea.Text = room.FloorArea.ToString() + " " + room.Measurement + "²";

                }

                //display the amount of paint required
                txtPaintRequired.Text = room.PaintRequired.ToString();

            }
            catch
            {
                //If any error appears
                MessageBox.Show("Invalid Input", "Error");
            }
        }

        private void PaintCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
