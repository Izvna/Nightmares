using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace Nightmares.Items.Weapons

{

    public class SlumberDisruption : ModItem

    {

        public override void SetStaticDefaults()

        {

            DisplayName.SetDefault("Slumber Disruption");
            Tooltip.SetDefault("A spear that attacks so fast its nearly uncontrollable");


        }



        public override void SetDefaults()

        {

            item.damage = 100;

            item.useStyle = 5;

            item.useAnimation = 5;

            item.useTime = 12;

            item.shootSpeed = 4.75f; // The shoot speed for the spear projectile.

            item.knockBack = 5.5f;

            item.width = 32;

            item.height = 32;

            item.scale = 1f; // The scale of the item.

            item.rare = 11;

            item.UseSound = SoundID.Item1;

            item.value = 1000;

            item.melee = true;

            item.autoReuse = true; // Will auto reuse the item.



            item.noMelee = true;

            item.noUseGraphic = true;

            item.shoot = mod.ProjectileType<Projectiles.SlumberDisruption>();
        }
		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 25);
			recipe.AddIngredient(ItemID.SoulofFright, 15);
			recipe.AddIngredient(null,"NitmarBarItem", 30);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }



        public override bool CanUseItem(Player player)

        {

            return player.ownedProjectileCounts[item.shoot] < 1; // Only one spear can be on screen at a time. 

        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 1 + Main.rand.Next(1); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(35)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false; 
         }   
    }
}