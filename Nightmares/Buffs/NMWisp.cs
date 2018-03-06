using Terraria;

using Terraria.ModLoader;



namespace Nightmares.Buffs

{

	public class NMWisp : ModBuff

	{

		public override void SetDefaults()

		{

			DisplayName.SetDefault("Nightmare Monolith");

			Description.SetDefault("Team Nightmare member since 2018.");

			Main.buffNoSave[Type] = true;

			Main.buffNoTimeDisplay[Type] = true;

		}



		public override void Update(Player player, ref int buffIndex)

		{

			NPlayer modPlayer = player.GetModPlayer<NPlayer>(mod);

			if (player.ownedProjectileCounts[mod.ProjectileType("NMWisp")] > 0)

			{

				modPlayer.NMMinion = true;

			}

			if (!modPlayer.NMMinion)

			{

				player.DelBuff(buffIndex);

				buffIndex--;

			}

			else

			{

				player.buffTime[buffIndex] = 18000;

			}

		}

	}

}