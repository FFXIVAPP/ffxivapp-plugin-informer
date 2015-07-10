// FFXIVAPP.Plugin.Informer
// Russian.cs
// 
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met: 
// 
//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution. 
//  * Neither the name of SyndicatedLife nor the names of its contributors may 
//    be used to endorse or promote products derived from this software 
//    without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE. 

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
