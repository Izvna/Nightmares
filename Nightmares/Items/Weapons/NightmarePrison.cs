using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Nightmares.Items.Weapons
{
    public class NightmarePrison : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare Prison");
			Tooltip.SetDefault("Rapidly unleashes unstoppable waves of Nightmares");
		}
		public override void SetDefaults()
        {         
            item.damage = 65;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 10;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 0;        
            item.value = 1000;
            item.rare = 11;
            item.mana = 30;             //mana use
            item.UseSound = SoundID.Item73;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("DemonSpirit");  //this make the item shoot your projectile
            item.shootSpeed = 8f;    //projectile speed when shoot
		}
			
		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.SoulofFright, 30);
			recipe.AddIngredient(null,"NitmarBarItem", 20);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)

        {      
		   target.AddBuff(BuffID.OnFire, 60);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 8 + Main.rand.Next(3); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false; 
         }   
    }
}
    
