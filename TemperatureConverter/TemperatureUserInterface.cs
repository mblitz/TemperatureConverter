//Author: Matthew Blitz
//Author's email: mblitz@csu.fullerton.edu
//Course: Cpsc223n
//Assignment number: 1
//Due date: Feb , 2014
//Project name: Temperature Conversion Project
//Files in project: TemperatureLogic.cs, TemperatureUserInterface.cs, TempConversionMain.cs
//Project purpose:  To learn how to build user interfaces
//Project status:  Works Correctly to all inputs
//Known bugs: No known bugs; Still testing
//
//This file's name: TemperatureUserInterface.cs
//This file purpose: This is a second level module; it defines the user interface window.
//Date last modified: Jan 21, 2014
//
//There are three files in this program.  They must be compiled in an order that satisfies dependencies.  In this case the correct order is:
//  1. TemperatureLogic.cs
//  2. TemperatureUserInterface.cs
//  3. TempConversionMain.cs
//
//Function: This is a temperature conversion program. Enter any number into the input field, then click on the Fahrenheit button
//to convert the number from Celsius to Fahrenheit. Or click the Celsius button to convert the number to Fahrenheit. The calculation
//is shown as a string below the input field as well as in an output box below the Fahrenheit and Celsius buttons. There is a clear
//button that will clear the input field. There is also an exit button that will exit the program. Below the output box, there is 
//a clear all button. Click this button to reset all fields. After clicking on any button except for exit, the input cursor is
//set to the input field, so the user can type another input.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


    public class TemperatureUserInterface : Form
    {
        private Button ConvertToF = new Button();
        private Button ConvertToC = new Button();
        private Button clear = new Button();
        private Button exit = new Button();
        private Button clearAll = new Button();
        private Label message = new Label();
        private Label topMessage = new Label();
        private Label message2 = new Label();
        private TextBox text = new TextBox();
        private Label TemperatureText = new Label();
        private Label ConvertedTempText = new Label();
        private Label OutputMessage = new Label();
        private char convertingTo;
        private string tempHold;

        private int outputNumber = 0;
        private double Temperature = 0.0;
        private double ConvertedTemp = 0.0;
        public TemperatureUserInterface()
        {

            //Button Text
            message2.Text = "Temperature Conversion\n" + "By Matthew Blitz";
            Text = "Temperature Calculator";
            ConvertToF.Text = "Convert to Fahrenheit";
            ConvertToC.Text = "Convert to Celsius";
            clear.Text = "Clear";
            exit.Text = "Exit";
            text.Text = "0";
            message.Text = "This is where the answer goes";
            topMessage.Text = "Enter a temperature in the box below: ";
            OutputMessage.Text = "";
            clearAll.Text = "Clear All";


            //Sizes
            Size = new Size(600, 400);
            message.Size = new Size(400, 30);
            topMessage.Size = new Size(200, 30);
            message2.Size = new Size(200, 30);
            ConvertToF.Size = new Size(150, 24);
            ConvertToC.Size = new Size(150, 24);
            OutputMessage.Size = new Size(330, 120);

            //Adding Colors
            ConvertToC.ForeColor = System.Drawing.Color.White;
            ConvertToF.ForeColor = System.Drawing.Color.White;
            ConvertToC.BackColor = System.Drawing.Color.MediumBlue;
            ConvertToF.BackColor = System.Drawing.Color.Crimson;

            //Locations
            message2.Location = new Point(30, 30);
            topMessage.Location = new Point(30, 70);
            text.Location = new Point(30, 90);
            message.Location = new Point(30, 120);
            ConvertToF.Location = new Point(20, 150);
            ConvertToC.Location = new Point(30 + ConvertToF.Width, 150);
            clear.Location = new Point(40 + ConvertToF.Width + ConvertToC.Width, 150);
            exit.Location = new Point(50 + ConvertToF.Width + ConvertToC.Width + clear.Width, 150);
            OutputMessage.Location = new Point(30, 190);
            clearAll.Location = new Point(30, 320);

            //Add Objects to the form
            Controls.Add(message2);
            Controls.Add(text);
            Controls.Add(ConvertToF);
            Controls.Add(ConvertToC);
            Controls.Add(clear);
            Controls.Add(message);
            Controls.Add(topMessage);
            Controls.Add(exit);
            Controls.Add(OutputMessage);
            Controls.Add(clearAll);
            //Click Events
            ConvertToF.Click += new EventHandler(ConvertToF_Click);
            ConvertToC.Click += new EventHandler(ConvertToC_Click);
            clear.Click += new EventHandler(Clear_Click);
            exit.Click += new EventHandler(Exit_Click);
            clearAll.Click += new EventHandler(ClearAll_Click);


        }

        //method to make ConvertToF Button work
        protected void ConvertToF_Click(Object sender, EventArgs e)
        {
            convertingTo = 'F';
            Temperature = double.Parse(text.Text);
            ConvertedTemp = TemperatureLogic.TemperatureConvert(convertingTo, Temperature);
            text.Text = Temperature.ToString();
            text.Focus();
            ConvertedTempText.Text = ConvertedTemp.ToString("f15");
            TemperatureText.Text = Temperature.ToString("f15");
            message.Text = TemperatureText.Text + "ᴼC" + "  =  " + ConvertedTempText.Text + "ᴼF";
            tempHold = message.Text;
            if (outputNumber < 9)
            {
                OutputMessage.Text += message.Text + '\n';
                outputNumber++;
            }
            else
            {
                outputNumber = 1;
                OutputMessage.Text = message.Text + '\n';
            }
        }
        //Method to make ConvertToF work
        protected void ConvertToC_Click(Object sender, EventArgs e)
        {
            convertingTo = 'C';
            Temperature = double.Parse(text.Text);
            ConvertedTemp = TemperatureLogic.TemperatureConvert(convertingTo, Temperature);
            text.Text = Temperature.ToString();
            text.Focus();
            ConvertedTempText.Text = ConvertedTemp.ToString("f15");
            TemperatureText.Text = Temperature.ToString("f15");

            message.Text = TemperatureText.Text + "ᴼF" + "  =  " + ConvertedTempText.Text + "ᴼC";
            if (outputNumber < 9)
            {
                OutputMessage.Text += message.Text + '\n';
                outputNumber++;
            }
            else
            {
                outputNumber = 1;
                OutputMessage.Text = message.Text + '\n';
            }
        }
        //method to make Clear button work
        protected void Clear_Click(Object sender, EventArgs e)
        {
            text.Text = "0";
            message.Text = "";
            text.Focus();
        }
        protected void Exit_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
        protected void ClearAll_Click(Object sender, EventArgs e)
        {
            OutputMessage.Text = "";
            text.Text = "0";
            message.Text = "";
            text.Focus();
        }
    }

