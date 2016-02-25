// FFXIVAPP.Plugin.Informer ~ Russian.cs
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
    public abstract class Russian
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
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
