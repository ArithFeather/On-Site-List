﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DustSwier.OnSiteList.Models
{
    public static class Extensions
    {
        /// <summary>
        /// Converts a letter into its corresponding index value from A to Z.
        /// </summary>
        public static byte ToByte(this char dorm)
        {
            switch (char.ToLower(dorm))
            {
                case 'a':
                    return 0;
                case 'b':
                    return 1;
                case 'c':
                    return 2;
                case 'd':
                    return 3;
                case 'e':
                    return 4;
                case 'f':
                    return 5;
                case 'g':
                    return 6;
                case 'h':
                    return 7;
                case 'i':
                    return 8;
                case 'j':
                    return 9;
                case 'k':
                    return 10;
                case 'l':
                    return 11;
                case 'm':
                    return 12;
                case 'n':
                    return 13;
                case 'o':
                    return 14;
                case 'p':
                    return 15;
                case 'q':
                    return 16;
                case 'r':
                    return 17;
                case 's':
                    return 18;
                case 't':
                    return 19;
                case 'u':
                    return 20;
                case 'v':
                    return 21;
                case 'w':
                    return 22;
                case 'x':
                    return 23;
                case 'y':
                    return 24;
                case 'z':
                    return 25;
            }
            throw new Exception("char is not between a and z.");
        }

        /// <summary>
        /// Converts an int into the corresponding char letter from A to Z.
        /// </summary>
        public static char ToChar(this byte index)
        {
            switch (index)
            {
                case 0:
                    return 'a';
                case 1:
                    return 'b';
                case 2:
                    return 'c';
                case 3:
                    return 'd';
                case 4:
                    return 'e';
                case 5:
                    return 'f';
                case 6:
                    return 'g';
                case 7:
                    return 'h';
                case 8:
                    return 'i';
                case 9:
                    return 'j';
                case 10:
                    return 'k';
                case 11:
                    return 'l';
                case 12:
                    return 'm';
                case 13:
                    return 'n';
                case 14:
                    return 'o';
                case 15:
                    return 'p';
                case 16:
                    return 'q';
                case 17:
                    return 'r';
                case 18:
                    return 's';
                case 19:
                    return 't';
                case 20:
                    return 'u';
                case 21:
                    return 'v';
                case 22:
                    return 'w';
                case 23:
                    return 'x';
                case 24:
                    return 'y';
                case 25:
                    return 'z';
            }
            throw new Exception("index is not a letter (0-25)");
        }
    }
}
