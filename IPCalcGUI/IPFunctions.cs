//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		IP Calculator
//	File Name:		IPFunctions.cs
//	Description:	A collection of static methods for computing information about an IP address
//	Course:			CSCI 3400 - Networking Fundamentals
//	Author:			Kevin Jackson, jacksonka1@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:	    Friday, February 12, 2016
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPCalcGUI
{
    class IPFunctions
    {
        #region IsValidIP
        /// <summary>
        /// Determines whether the given string is a valid ip address.
        /// </summary>
        /// <param name="addr">The string.</param>
        /// <returns>A <see cref="bool"/> indicating whether the given ip address is valid</returns>
        public static bool IsValidIP(string addr)
        {
            bool isValid = true;
            string[] octects = addr.Split('.');
            foreach (string s in octects)
            {
                int num = 0;
                if (Int32.TryParse(s, out num))
                    isValid = isValid && num < 256 && num >= 0;
                else
                    isValid = false;
            }
            return isValid;
        }
        #endregion

        #region FindClass
        /// <summary>
        /// Finds the class for the given ip address.
        /// </summary>
        /// <param name="addr">The ip address.</param>
        /// <returns></returns>
        public static string FindClass(string addr)
        {
            string[] octets = addr.Split('.');
            int num = 0;
            string ipClass = "(none)";
            Int32.TryParse(octets[0], out num);
            if (num >= 0 && num <= 127)
                ipClass = "A";
            else if (num > 127 && num <= 191)
                ipClass = "B";
            else if (num > 191 && num <= 223)
                ipClass = "C";
            else if (num > 223 && num <= 239)
                ipClass = "D";
            else if (num > 239 && num <= 255)
                ipClass = "E";
            return ipClass;
        }
        #endregion

        #region FindMask
        /// <summary>
        /// Finds the the default subnet mask for an ip address with the given class.
        /// </summary>
        /// <param name="cl">The class of an ip address.</param>
        /// <returns></returns>
        public static string FindMask(string cl)
        {
            string defaultMask = "0.0.0.0";
            if (cl == "A")
                defaultMask = "255.0.0.0";
            else if (cl == "B")
                defaultMask = "255.255.0.0";
            else if (cl == "C")
                defaultMask = "255.255.255.0";
            else if (cl == "D" || cl == "E")
                defaultMask = "Not defined";
            return defaultMask;
        }
        #endregion

        #region FindHostBits
        /// <summary>
        /// Finds the host bits for an ip address in the given class.
        /// </summary>
        /// <param name="cl">The cl.</param>
        /// <returns></returns>
        public static int FindHostBits(string cl)
        {
            int hostBits = 0;
            if (cl == "A")
                hostBits = 24;
            else if (cl == "B")
                hostBits = 16;
            else if (cl == "C")
                hostBits = 8;
            return hostBits;
        }
        #endregion

        #region FindNetworkBits
        /// <summary>
        /// Finds the network bitsfor an ip address in the given class.
        /// </summary>
        /// <param name="cl">The cl.</param>
        /// <returns></returns>
        public static int FindNetworkBits(string cl)
        {
            int networkBits = 0;
            if (cl == "A")
                networkBits = 8;
            else if (cl == "B")
                networkBits = 16;
            else if (cl == "C")
                networkBits = 24;
            return networkBits;
        }
        #endregion

        #region FindNetworkAddress
        /// <summary>
        /// Finds the network address for a given ip address's subnet.
        /// </summary>
        /// <param name="addr">The address.</param>
        /// <param name="cl">The class.</param>
        /// <returns>A <see cref="string"/> containing the network address</returns>
        public static string FindNetworkAddress(string addr, string cl)
        {
            string[] octects = addr.Split('.');
            string networkAddress = "";
            if (cl == "A")
            {
                // last octect = 0
                for (int i = 0; i < 3; i++)
                    networkAddress += octects[i] + ".";
                networkAddress += "0";
            }
            else if (cl == "B")
            {
                // last 2 octects = 0
                for (int i = 0; i < 2; i++)
                    networkAddress += octects[i] + ".";
                networkAddress += "0.0";
            }
            else if (cl == "C")
            {
                networkAddress += octects[0] + ".0.0.0";
            }
            return networkAddress;
        }
        #endregion

        #region FindBroadcastAddress
        /// <summary>
        /// Finds the network address for a given ip address's subnet.
        /// </summary>
        /// <param name="addr">The address.</param>
        /// <param name="cl">The class.</param>
        /// <returns>A <see cref="string"/> containing the broadcast address</returns>
        public static string FindBroadcastAddress(string addr, string cl)
        {
            string[] octects = addr.Split('.');
            string networkAddress = "";
            if (cl == "A")
            {
                // last octect = 0
                for (int i = 0; i < 3; i++)
                    networkAddress += octects[i] + ".";
                networkAddress += "255";
            }
            else if (cl == "B")
            {
                // last 2 octects = 0
                for (int i = 0; i < 2; i++)
                    networkAddress += octects[i] + ".";
                networkAddress += "255.255";
            }
            else if (cl == "C")
            {
                networkAddress += octects[0] + ".255.255.255";
            }
            return networkAddress;
        }
        #endregion

        #region FindNetworkSize
        /// <summary>
        /// Finds the size of the network based on the number of host bits.
        /// </summary>
        /// <param name="hostBits">The number of host bits.</param>
        /// <returns></returns>
        public static string FindNetworkSize(int hostBits)
        {
            return Math.Pow(2, hostBits).ToString();
        }
        #endregion
    }
}
