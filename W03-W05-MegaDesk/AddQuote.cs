﻿using Newtonsoft.Json;
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


namespace MegaDesk
{
    public partial class AddQuotesForm : Form
    {
        public AddQuotesForm()
        {
            InitializeComponent();
            CreateQuoteButton.Enabled = false;
            DateTime now = DateTime.Now;
            CurrentDate.Text = now.ToString("dd MMMM yyyy");
        }

        public static string customerNameValue;
        public static int rushDaysValue;
        public static int widthValue;
        public static int depthValue;
        public static int numDrawersValue;
        public static string surfaceMaterialValue;
        public static DateTime currentDate;

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        public int getDrawerCount()
        {
            return (int)NumDrawers.Value;
        }
        
        // Validate form to alert user when input is in/out of bounds
        private void CheckForm()
        {
            bool formOkay = true;
            if(CustomerName.Text != "")
            {
                CustomerNameHelperText.BackColor = Color.FromArgb(240, 240, 240);
                CustomerNameHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                CustomerNameHelperText.BackColor = Color.Red;
                CustomerNameHelperText.ForeColor = Color.White;
            }

            if(RushDays.Text != "")
            {
                RushDaysHelperText.BackColor = Color.FromArgb(240, 240, 240);
                RushDaysHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                RushDaysHelperText.BackColor = Color.Red;
                RushDaysHelperText.ForeColor = Color.White;
            }

            if (Width.Value >= 24 && Width.Value <= 96)
            {
                WidthHelperText.BackColor = Color.FromArgb(240, 240, 240);
                WidthHelperText.ForeColor = Color.Green;
            }
            else
            {
                formOkay = false;
                WidthHelperText.BackColor = Color.Red;
                WidthHelperText.ForeColor = Color.White;
            }

            if(Depth.Value >= 12 && Depth.Value <= 48)
            {
                DepthHelperText.BackColor = Color.FromArgb(240, 240, 240);
                DepthHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                DepthHelperText.BackColor = Color.Red;
                DepthHelperText.ForeColor = Color.White;
            }

            if(NumDrawers.Value >= 0 && NumDrawers.Value <= 7)
            {
                DrawersHelperText.BackColor = Color.FromArgb(240, 240, 240);
                DrawersHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                DrawersHelperText.BackColor = Color.Red;
                DrawersHelperText.ForeColor = Color.White;
            }

            if (SurfaceMaterial.Text != "")
            {
                SurfaceHelperText.BackColor = Color.FromArgb(240, 240, 240);
                SurfaceHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                SurfaceHelperText.BackColor = Color.Red;
                SurfaceHelperText.ForeColor = Color.White;
            }



            if (formOkay == true)
            {
                CreateQuoteButton.Enabled = true;
            } else
            {
                CreateQuoteButton.Enabled = false;
            }
        }

        private void Width_ValueChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void Depth_ValueChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void NumDrawers_ValueChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void SurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void CreateQuoteButton_Click(object sender, EventArgs e)
        {
            customerNameValue = CustomerName.Text;
            rushDaysValue = Convert.ToInt32(RushDays.Text);
            widthValue = (int) Width.Value;
            depthValue = (int) Depth.Value;
            numDrawersValue = (int) NumDrawers.Value;
            surfaceMaterialValue = SurfaceMaterial.Text;

            currentDate = DateTime.Now;
            // saved currentdate in string so the format is nice for the JSON file
            string orderDate = currentDate.ToString("dd MMMM yyyy");
            //rushCostValue = ;

            Desk customerDesk = new Desk(widthValue, depthValue, numDrawersValue, surfaceMaterialValue);
            DeskQuote customerQuote = new DeskQuote(customerNameValue, customerDesk, rushDaysValue, orderDate);
            Program.Quotes.Add(customerQuote);

            //private static Desk customerDesk = new Desk(widthValue, depthValue, numDrawersValue, surfaceMaterialValue);
            //private static DeskQuote customerQuote = new DeskQuote(customerNameValue, customerDesk, rushDaysValue);

            //  Saving JSON to text file
            #region Save Quotes to JSON file / serialize/deserialize
            var json = "";
            try
            {

                json = JsonConvert.SerializeObject(Program.Quotes);

                string fileName = @"quotes.json";
                List<DeskQuote> deskOrders = new List<DeskQuote>();

                if (File.Exists(fileName))
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string quotes = reader.ReadToEnd();
                        if(quotes.Length > 0)
                        {
                            deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                        }
                        deskOrders.Add(customerQuote);
                    }

                    // convert to Json
                    var serializedOrders = JsonConvert.SerializeObject(deskOrders);
                    // save to json
                    File.WriteAllText(fileName, serializedOrders);
                }
                else
                {
                    deskOrders = new List<DeskQuote> { customerQuote };
                    var serializedOrders = JsonConvert.SerializeObject(deskOrders);
                    // save to json
                    File.WriteAllText(fileName, serializedOrders);
                }
                #endregion

                //File.WriteAllText(@"quotes.json", JsonConvert.SerializeObject(Program.Quotes));
                // using (StreamWriter x = File.WriteAllText(fileName))
                //{
                //   x.WriteLine(json);
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error writing to file.");
            }




            DisplayQuote viewDisplayQuote = new DisplayQuote();

            viewDisplayQuote.Tag = this.Tag;
            viewDisplayQuote.Show();
            Hide();
        }

        

        private void CustomerName_TextChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void RushDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void AddQuotesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
