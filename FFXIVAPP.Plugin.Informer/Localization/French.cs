// FFXIVAPP.Plugin.Informer ~ French.cs
// 
// Copyright © 2007 - 2017 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Windows;

namespace FFXIVAPP.Plugin.Informer.Localization
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
