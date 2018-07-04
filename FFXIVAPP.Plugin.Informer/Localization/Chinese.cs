// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Chinese.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Chinese.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Informer.Localization {
    using System.Windows;

    public abstract class Chinese {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context() {
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