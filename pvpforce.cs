using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace forcedpvp
{
    class pvpforce : ModPlayer
    {
        public override void PostUpdate()
        {
            player.hostile = !ModContent.GetInstance<forcedpvpConfigServer>().Active;
            if (ModContent.GetInstance<forcedpvpConfigServer>().Allowed) Main.teamCooldown = 600000;
            else Main.teamCooldown = 0;
            base.PostUpdate();
        }

    }

}
