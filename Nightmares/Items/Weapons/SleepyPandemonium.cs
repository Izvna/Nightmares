using System;

using System.Collections.Generic;

using System.Linq;

using Microsoft.Xna.Framework;

using System.Text;

using System.Threading.Tasks;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace Nightmares.Items.Weapons

{

    public class SleepyPandemonium : ModItem

    {

        public override void SetStaticDefaults()

        {

            DisplayName.SetDefault("Sleepy Pandemonium");
   	        Tooltip.SetDefault("A bow as strong as a nightmarish monster\nShoots bright dream lasers instead of wooden arrows");
 	    } 



        public override void SetDefaults()

        {

            item.damage = 175;
			
			item.knockBack = 15.5f;
			
			item.width = 16;

            item.height = 24;

            item.useTime = 25;

            item.useAnimation = 20;

            item.useStyle = 5; // Bow Use Style

            item.noMelee = true; // Doesn't deal damage if an enemy touches at melee range.

            item.value = Item.buyPrice(0, 5, 0, 0); // Another way to handle value of item.

            item.rare = 11;

            item.UseSound = SoundID.Item25; // Sound for Bows

            item.useAmmo = AmmoID.Arrow; // The ammo used with this weapon

            item.shoot = 1;

            item.shootSpeed = 9.8f;

            item.ranged = true; // For Ranged Weapon

        }
        public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 30);
			recipe.AddIngredient(ItemID.SoulofFright, 25);
			recipe.AddIngredient(null,"NitmarBarItem", 15);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = mod.ProjectileType("DreamLaser");
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }
    }
}    