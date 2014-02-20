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
//This file's name: TemperatureLogic.cs
//This file purpose: This is a third level module; it is called from TemperatureUserInterface.cs.
//Date last modified: Jan 21, 2014
//
//There are three files in this program.  They must be compiled in an order that satisfies dependencies.  In this case the correct order is:
//  1. TemperatureLogic.cs
//  2. TemperatureUserInterface.cs
//  3. TempConversionMain.cs


    public class TemperatureLogic
    {
        public static double TemperatureConvert(char convertTo, double temperature)
        {
            if (convertTo == 'F')
            {
                return ((temperature * 1.8) + 32);
            }
            else
            {
                return ((temperature - 32) / 1.8);
            }
        }//End of TemperatureConvert
    }//End of TemperatureLogic
