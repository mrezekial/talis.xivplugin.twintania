﻿// Talis.XIVPlugin.Twintania
// French.cs
// 
// 	

using System.Windows;

namespace Talis.XIVPlugin.Twintania.Localization
{
    public abstract class French
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            return Dictionary;
        }
    }
}
