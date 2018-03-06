using Microsoft.Xna.Framework;

using Terraria;

using Terraria.ID;



namespace Nightmares.Projectiles.Minions

{

	//ported from my tAPI mod because I'm lazy

	public class NMWisp : HoverShooter

	{

		public override void SetStaticDefaults()

		{

			Main.projFrames[projectile.type] = 8;

			Main.projPet[projectile.type] = true;

			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;

			ProjectileID.Sets.Homing[projectile.type] = true;

			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true; //This is necessary for right-click targeting

		}



		public override void SetDefaults()

		{

			projectile.netImportant = true;

			projectile.width = 24;

			projectile.height = 32;

			projectile.friendly = true;

			projectile.minion = true;

			projectile.minionSlots = 1;

			projectile.penetrate = -1;

			projectile.timeLeft = 18000;

			projectile.tileCollide = false;

			projectile.ignoreWater = true;

			inertia = 20f;

			shoot = mod.ProjectileType("NMBolt");

			shootSpeed = 6f;

		}



		public override void CheckActive()

		{

			Player player = Main.player[projectile.owner];

			NPlayer modPlayer = player.GetModPlayer<NPlayer>(mod);

			if (player.dead)

			{

				modPlayer.NMMinion = false;

			}

			if (modPlayer.NMMinion)

			{

				projectile.timeLeft = 2;

			}

		}

		public override void SelectFrame()

		{

			int ticksPerFrame = 10; // number of ticks between each frame
            projectile.frameCounter++;
            if (projectile.frameCounter > ticksPerFrame)
            {
                projectile.frameCounter = 0;
                projectile.frame++;
                if (projectile.frame >= Main.projFrames[projectile.type])
                {
                    projectile.frame = 0;
                }
			
			}

		}

	}

}