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
    public class forcedpvpConfigServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("Disable PvP")]
		[Tooltip("Disables PvP if enabled")]
		public bool Active { get; set; }

		[Label("Disable team changing")]
		[Tooltip("Disables team changing if enabled")]
		public bool Allowed { get; set; }


		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			if (Main.player[whoAmI].name != "Gnidolin" || Main.player[whoAmI].name != "Gratfor")
			{
				message = "Sorry, you are not allowed to change these settings.";
				return false;
			}
			return true;
		}

	}
}
