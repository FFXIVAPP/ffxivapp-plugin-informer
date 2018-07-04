// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Japanese.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Japanese.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Informer.Localization {
    using System.Windows;

    public abstract class Japanese {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context() {
            Dictionary.Clear();
            Dictionary.Add("informer_", "*PH*");
            Dictionary.Add("informer_PlayerTabHeader", "プレイヤー");
            Dictionary.Add("informer_AgroTabHeader", "敵対");
            Dictionary.Add("informer_TargetsTabHeader", "ターゲット");
            Dictionary.Add("informer_TargetEnmityTabHeader", "敵対グループ");
            Dictionary.Add("informer_CurrentPlayerHeader", "現在のプレイヤー");
            Dictionary.Add("informer_CurrentAgroHeader", "現在の敵対対象");
            Dictionary.Add("informer_CurrentTargetHeader", "現在のターゲット");
            Dictionary.Add("informer_FocusTargetHeader", "フォーカスターゲット");
            Dictionary.Add("informer_MouseOverTargetHeader", "マウスオーバーターゲット");
            Dictionary.Add("informer_PreviousTargetHeader", "前のターゲット");
            Dictionary.Add("informer_NameHeader", "名前");
            Dictionary.Add("informer_LevelLabel", "レベル:");
            Dictionary.Add("informer_HPLabel", "HP:");
            Dictionary.Add("informer_MPLabel", "MP:");
            Dictionary.Add("informer_TPLabel", "TP:");
            Dictionary.Add("informer_GPLabel", "GP:");
            Dictionary.Add("informer_CPLabel", "CP:");
            Dictionary.Add("informer_StatusCountLabel", "ステータスカウント:");
            Dictionary.Add("informer_EnmityHeader", "敵対グループ:");
            Dictionary.Add("informer_NameLabel", "名前:");
            Dictionary.Add("informer_EnmityPercentHeader", "敵対%");
            Dictionary.Add("informer_GitHubButtonText", "Open Project Source (GitHub)");
            Dictionary.Add("informer_StatusEntriesHeader", "Status Entries");
            Dictionary.Add("informer_DurationHeader", "Duration");
            Dictionary.Add("informer_IDHeader", "ID");
            return Dictionary;
        }
    }
}