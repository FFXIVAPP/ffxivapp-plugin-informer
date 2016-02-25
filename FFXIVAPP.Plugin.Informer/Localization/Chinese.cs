// FFXIVAPP.Plugin.Informer ~ Chinese.cs
// 
// Copyright © 2007 - 2016 Ryan Wilson - All Rights Reserved
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
    public abstract class Chinese
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("informer_", "*PH*");
            Dictionary.Add("informer_PlayerTabHeader", "玩家");
            Dictionary.Add("informer_AgroTabHeader", "Agro");
            Dictionary.Add("informer_TargetsTabHeader", "目标");
            Dictionary.Add("informer_TargetEnmityTabHeader", "敌意目标");
            Dictionary.Add("informer_CurrentPlayerHeader", "当前玩家");
            Dictionary.Add("informer_CurrentAgroHeader", "当前 Agro");
            Dictionary.Add("informer_CurrentTargetHeader", "当前目标");
            Dictionary.Add("informer_FocusTargetHeader", "焦点目标");
            Dictionary.Add("informer_MouseOverTargetHeader", "MouseOver目标");
            Dictionary.Add("informer_PreviousTargetHeader", "前目标");
            Dictionary.Add("informer_NameHeader", "名称");
            Dictionary.Add("informer_LevelLabel", "级别:");
            Dictionary.Add("informer_HPLabel", "HP:");
            Dictionary.Add("informer_MPLabel", "MP:");
            Dictionary.Add("informer_TPLabel", "TP:");
            Dictionary.Add("informer_GPLabel", "GP:");
            Dictionary.Add("informer_CPLabel", "CP:");
            Dictionary.Add("informer_StatusCountLabel", "状态值:");
            Dictionary.Add("informer_EnmityHeader", "敌意");
            Dictionary.Add("informer_NameLabel", "名称:");
            Dictionary.Add("informer_EnmityPercentHeader", "敌意 %");
            Dictionary.Add("informer_GitHubButtonText", "打开项目源代码 (GitHub)");
            Dictionary.Add("informer_StatusEntriesHeader", "状态项目");
            Dictionary.Add("informer_DurationHeader", "持续时间");
            Dictionary.Add("informer_IDHeader", "ID");
            return Dictionary;
        }
    }
}
