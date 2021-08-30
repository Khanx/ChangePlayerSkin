using Chatting;
using System.Collections.Generic;

namespace ChangePlayerSkin
{
    [ChatCommandAutoLoader]
    public class ChangeSkinC : IChatCommand
    {
        private Dictionary<string, string> idSkin = new Dictionary<string, string>();

        public ChangeSkinC()
        {
            idSkin.Add("", "");
        }

        public bool TryDoCommand(Players.Player player, string chat, List<string> splits)
        {
            if (!splits[0].ToLower().Equals("/changeskin"))
                return false;

            if (splits.Count == 1)
            {
                ChangeSkin.ChangePlayerSkin(player.ID, NPC.NPCType.GetByKeyNameOrDefault("pipliz.networkplayer").Type);
                Chat.Send(player, "Skin changed to: player");

                return true;
            }

            switch (splits[1])
            {
                case "1":
                    ChangeSkin.ChangePlayerSkin(player.ID, NPC.NPCType.GetByKeyNameOrDefault("pipliz.merchant").Type);
                    Chat.Send(player, "Skin changed to: merchant");
                    break;
                case "2":
                    ChangeSkin.ChangePlayerSkin(player.ID, NPC.NPCType.GetByKeyNameOrDefault("pipliz.scientist").Type);
                    Chat.Send(player, "Skin changed to: scientist");
                    break;
                case "3":
                    ChangeSkin.ChangePlayerSkin(player.ID, NPC.NPCType.GetByKeyNameOrDefault("pipliz.monsterac").Type);
                    Chat.Send(player, "Skin changed to: monsterac");
                    break;
                default:
                    ChangeSkin.ChangePlayerSkin(player.ID, NPC.NPCType.GetByKeyNameOrDefault("pipliz.networkplayer").Type);
                    Chat.Send(player, "Skin changed to: player");
                    break;
            }

            return true;
        }
    }
}
