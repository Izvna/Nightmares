using System;

using System.Collections.Generic;

using System.IO;

using Microsoft.Xna.Framework;

using Microsoft.Xna.Framework.Graphics;

using Terraria;

using Terraria.DataStructures;

using Terraria.ID;

using Terraria.ModLoader;

using Terraria.ModLoader.IO;

using Terraria.GameInput;



namespace Nightmares

{

	public class NPlayer : ModPlayer

	{

		
		public int NMDebuffCooldown = 0;

		public bool NMMinion = false;

		



		public override void ResetEffects()

		{

			

			NMMinion = false;

			

		}

	}

}