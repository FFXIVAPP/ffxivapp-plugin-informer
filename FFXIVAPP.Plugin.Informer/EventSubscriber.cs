// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventSubscriber.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   EventSubscriber.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Informer {
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using FFXIVAPP.Common.Core.Constant;
    using FFXIVAPP.IPluginInterface.Events;
    using FFXIVAPP.Plugin.Informer.ViewModels;

    using Sharlayan.Core;

    public static class EventSubscriber {
        public static void Subscribe() {
            Plugin.PHost.ConstantsUpdated += OnConstantsUpdated;

            // Plugin.PHost.NewChatLogEntry += OnNewChatLogEntry;
            Plugin.PHost.MonsterItemsUpdated += OnMonsterItemsUpdated;
            Plugin.PHost.NPCItemsUpdated += OnNewNPCItemsUpdated;
            Plugin.PHost.PCItemsUpdated += OnNewPCItemsUpdated;
            Plugin.PHost.CurrentPlayerUpdated += OnCurrentPlayerUpdated;
            Plugin.PHost.TargetInfoUpdated += OnTargetInfoUpdated;

            // Plugin.PHost.NewPartyEntries += OnNewPartyEntries;
        }

        public static void UnSubscribe() {
            Plugin.PHost.ConstantsUpdated -= OnConstantsUpdated;

            // Plugin.PHost.NewChatLogEntry -= OnNewChatLogEntry;
            Plugin.PHost.MonsterItemsUpdated -= OnMonsterItemsUpdated;
            Plugin.PHost.NPCItemsUpdated -= OnNewNPCItemsUpdated;
            Plugin.PHost.PCItemsUpdated -= OnNewPCItemsUpdated;
            Plugin.PHost.CurrentPlayerUpdated -= OnCurrentPlayerUpdated;
            Plugin.PHost.TargetInfoUpdated -= OnTargetInfoUpdated;

            // Plugin.PHost.NewPartyEntries -= OnNewPartyEntries;
        }

        private static void OnConstantsUpdated(object sender, ConstantsEntityEvent constantsEntityEvent) {
            // delegate event from constants, not required to subsribe, but recommended as it gives you app settings
            if (sender == null) {
                return;
            }

            ConstantsEntity constantsEntity = constantsEntityEvent.ConstantsEntity;
            Constants.AutoTranslate = constantsEntity.AutoTranslate;
            Constants.ChatCodes = constantsEntity.ChatCodes;
            Constants.Colors = constantsEntity.Colors;
            Constants.CultureInfo = constantsEntity.CultureInfo;
            Constants.CharacterName = constantsEntity.CharacterName;
            Constants.ServerName = constantsEntity.ServerName;
            Constants.GameLanguage = constantsEntity.GameLanguage;
            Constants.EnableHelpLabels = constantsEntity.EnableHelpLabels;
            Constants.Theme = constantsEntity.Theme;
            PluginViewModel.Instance.EnableHelpLabels = Constants.EnableHelpLabels;
        }

        private static void OnCurrentPlayerUpdated(object sender, CurrentPlayerEvent currentPlayerEvent) {
            // delegate event from player info from ram, not required to subsribe
            // this is for YOU and includes all your stats and your agro list with hate values as %
            // this updates 10x a second and only sends data when the newly read data is differen than what was previously sent
            if (sender == null) {
                return;
            }

            CurrentPlayer currentPlayer = currentPlayerEvent.CurrentPlayer;
            XIVInfoViewModel.Instance.AgroEntries = new ObservableCollection<EnmityItem>(currentPlayer.EnmityItems ?? new List<EnmityItem>());
        }

        // private static void OnNewChatLogEntry(object sender, ChatLogEntryEvent chatLogEntryEvent)
        // {
        // // delegate event from chat log, not required to subsribe
        // // this updates 100 times a second and only sends a line when it gets a new one
        // if (sender == null)
        // {
        // return;
        // }
        // var chatLogEntry = chatLogEntryEvent.ChatLogEntry;
        // }
        private static void OnMonsterItemsUpdated(object sender, ActorItemsEvent actorItemsEvent) {
            // delegate event from monster entities from ram, not required to subsribe
            // this updates 10x a second and only sends data if the items are found in ram
            // currently there no change/new/removed event handling (looking into it)
            if (sender == null) {
                return;
            }

            ConcurrentDictionary<uint, ActorItem> monsterEntities = actorItemsEvent.ActorItems;
            XIVInfoViewModel.Instance.CurrentMonsters = monsterEntities;
        }

        private static void OnNewNPCItemsUpdated(object sender, ActorItemsEvent actorItemsEvent) {
            // delegate event from npc entities from ram, not required to subsribe
            // this list includes anything that is not a player or monster
            // this updates 10x a second and only sends data if the items are found in ram
            // currently there no change/new/removed event handling (looking into it)
            if (sender == null) {
                return;
            }

            ConcurrentDictionary<uint, ActorItem> npcEntities = actorItemsEvent.ActorItems;
            XIVInfoViewModel.Instance.CurrentNPCs = npcEntities;
        }

        private static void OnNewPCItemsUpdated(object sender, ActorItemsEvent actorItemsEvent) {
            // delegate event from player entities from ram, not required to subsribe
            // this updates 10x a second and only sends data if the items are found in ram
            // currently there no change/new/removed event handling (looking into it)
            if (sender == null) {
                return;
            }

            ConcurrentDictionary<uint, ActorItem> pcEntities = actorItemsEvent.ActorItems;
            XIVInfoViewModel.Instance.CurrentPCs = pcEntities;
        }

        private static void OnTargetInfoUpdated(object sender, TargetInfoEvent targetInfoEvent) {
            // delegate event from target info from ram, not required to subsribe
            // this includes the full entities for current, previous, mouseover, focus targets (if 0+ are found)
            // it also includes a list of upto 16 targets that currently have hate on the currently targeted monster
            // these hate values are realtime and change based on the action used
            // this updates 10x a second and only sends data when the newly read data is differen than what was previously sent
            if (sender == null) {
                return;
            }

            TargetInfo targetInfo = targetInfoEvent.TargetInfo;

            if (ActorItem.CurrentUser != null) {
                XIVInfoViewModel.Instance.CurrentUser = ActorItem.CurrentUser;
            }

            XIVInfoViewModel.Instance.EnmityEntries = new ObservableCollection<EnmityItem>(targetInfo.EnmityItems ?? new List<EnmityItem>());
            XIVInfoViewModel.Instance.CurrentTarget = targetInfo.CurrentTarget ?? new ActorItem();
            XIVInfoViewModel.Instance.MouseOverTarget = targetInfo.MouseOverTarget ?? new ActorItem();
            XIVInfoViewModel.Instance.FocusTarget = targetInfo.FocusTarget ?? new ActorItem();
            XIVInfoViewModel.Instance.PreviousTarget = targetInfo.PreviousTarget ?? new ActorItem();
        }

        // private static void OnNewPartyEntries(object sender, PartyEntitiesEvent partyEntitiesEvent)
        // {
        // // delegate event that shows current party basic info
        // if (sender == null)
        // {
        // return;
        // }
        // var partyEntities = partyEntitiesEvent.PartyEntities;
        // }
    }
}