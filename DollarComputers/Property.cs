﻿/*
Application Name        : Dollar Computers
Author's Name           : Rutul Shah
Student ID              : 200329341 
Application Description : This application lets user to select from a 
                          wide range of computers and laptops along with hardware components. 
                          Open box laptops and computers are also available.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputers
{
    //creating a static class
    public static class Property
    {
        //storing all the result into static 
        //variables so that every page can access its values
        public static short productID { get; set; }

        public static decimal cost { get; set; }

        public static string manufacturer { get; set; }

        public static string model { get; set; }

        public static string RAM_type { get; set; }

        public static string RAM_size { get; set; }

        public static string displaytype { get; set; }

        public static string screensize { get; set; }

        public static string resolution { get; set; }

        public static string CPU_Class { get; set; }

        public static string CPU_brand { get; set; }

        public static string CPU_type { get; set; }

        public static string CPU_speed { get; set; }

        public static string CPU_number { get; set; }

        public static string condition { get; set; }

        public static string OS { get; set; }

        public static string platform { get; set; }

        public static string HDD_size { get; set; }

        public static string HDD_speed { get; set; }

        public static string GPU_Type { get; set; }

        public static string optical_drive { get; set; }

        public static string Audio_type { get; set; }

        public static string LAN { get; set; }

        public static string WIFI { get; set; }

        public static string width { get; set; }

        public static string height { get; set; }

        public static string depth { get; set; }

        public static string weight { get; set; }

        public static string moust_type { get; set; }

        public static string power { get; set; }

        public static string webcam { get; set; }
    }
}
