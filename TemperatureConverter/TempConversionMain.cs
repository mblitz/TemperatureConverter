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
//This file's name: TempConversionMain.cs
//This file purpose: This is the top level module; it launches the user interface window.
//Date last modified: Jan 21, 2014
//
//There are three files in this program.  They must be compiled in an order that satisfies dependencies.  In this case the correct order is:
//  1. TemperatureLogic.cs
//  2. TemperatureUserInterface.cs
//  3. TempConversionMain.cs


using System;
using System.Windows.Forms;

    public class TemperatureMain
    {
        [STAThread]
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Main method of the Temperature Conversion program.");
            TemperatureUserInterface tempapp = new TemperatureUserInterface();
            Application.Run(tempapp);
            System.Console.WriteLine("Main method will now shutdown.");
        }
    }
