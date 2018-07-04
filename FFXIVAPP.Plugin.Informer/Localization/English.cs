// --------------------------------------------------------------------------------------------------------------------
// <copyright file="English.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   English.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Informer.Localization {
    using System.Windows;

    public abstract class English {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context() {
            Dictionary.Clear();
            Dictionary.Add("informer_", "*PH*");
            Dictionary.Add("informer_PlayerTabHeader", "Player");
            Dictionary.Add("informer_AgroTabHeader", "Agro");
            Dictionary.Add("informer_TargetsTabHeader", "Targets");
            Dictionary.Add("informer_TargetEnmityTabHeader", "Target Enmity");
            Dictionary.Add("informer_CurrentPlayerHeader", "Current Player");
            Dictionary.Add("informer_CurrentAgroHeader", "Current Agro");
            Dictionary.Add("informer_CurrentTargetHeader", "Current Target");
            Dictionary.Add("informer_FocusTargetHeader", "Focus Target");
            Dictionary.Add("informer_MouseOverTargetHeader", "MouseOver Target");
            Dictionary.Add("informer_PreviousTargetHeader", "Previous Target");
            Dictionary.Add("informer_NameHeader", "Name");
            Dictionary.Add("informer_LevelLabel", "Level:");
            Dictionary.Add("informer_HPLabel", "HP:");
            Dictionary.Add("informer_MPLabel", "MP:");
            Dictionary.Add("informer_TPLabel", "TP:");
            Dictionary.Add("informer_GPLabel", "GP:");
            Dictionary.Add("informer_CPLabel", "CP:");
            Dictionary.Add("informer_StatusCountLabel", "Status Count:");
            Dictionary.Add("informer_EnmityHeader", "Enmity");
            Dictionary.Add("informer_NameLabel", "Name:");
            Dictionary.Add("informer_EnmityPercentHeader", "Enmity %");
            Dictionary.Add("informer_GitHubButtonText", "Open Project Source (GitHub)");
            Dictionary.Add("informer_StatusEntriesHeader", "Status Entries");
            Dictionary.Add("informer_DurationHeader", "Duration");
            Dictionary.Add("informer_IDHeader", "ID");
            return Dictionary;
        }
    }
}