// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Russian.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Russian.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Informer.Localization {
    using System.Windows;

    public abstract class Russian {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context() {
            Dictionary.Clear();
            Dictionary.Add("informer_", "*PH*");
            Dictionary.Add("informer_PlayerTabHeader", "Игрок");
            Dictionary.Add("informer_AgroTabHeader", "Агрессия");
            Dictionary.Add("informer_TargetsTabHeader", "Цели");
            Dictionary.Add("informer_TargetEnmityTabHeader", "Агрессия Цели");
            Dictionary.Add("informer_CurrentPlayerHeader", "Выбранный Игрок");
            Dictionary.Add("informer_CurrentAgroHeader", "Агрессия");
            Dictionary.Add("informer_CurrentTargetHeader", "Выбранная Цель");
            Dictionary.Add("informer_FocusTargetHeader", "Цель в фокусе");
            Dictionary.Add("informer_MouseOverTargetHeader", "Цель под указателем");
            Dictionary.Add("informer_PreviousTargetHeader", "Предыдущая Цель");
            Dictionary.Add("informer_NameHeader", "Имя");
            Dictionary.Add("informer_LevelLabel", "Уровень:");
            Dictionary.Add("informer_HPLabel", "HP:");
            Dictionary.Add("informer_MPLabel", "MP:");
            Dictionary.Add("informer_TPLabel", "TP:");
            Dictionary.Add("informer_GPLabel", "GP:");
            Dictionary.Add("informer_CPLabel", "CP:");
            Dictionary.Add("informer_StatusCountLabel", "Статус счёта:");
            Dictionary.Add("informer_EnmityHeader", "Агрессия");
            Dictionary.Add("informer_NameLabel", "Имя:");
            Dictionary.Add("informer_EnmityPercentHeader", "Агрессия %");
            Dictionary.Add("informer_GitHubButtonText", "Страница Проекта (GitHub)");
            Dictionary.Add("informer_StatusEntriesHeader", "Статус Записи");
            Dictionary.Add("informer_DurationHeader", "Продолжительность");
            Dictionary.Add("informer_IDHeader", "ID");
            return Dictionary;
        }
    }
}