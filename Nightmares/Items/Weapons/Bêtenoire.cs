using Microsoft.Xna.Framework;

using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace Nightmares.Items.Weapons

{

	//imported from my tAPI mod because I'm lazy

	public class Bêtenoire : ModItem

	{

		public override void SetStaticDefaults()

		{

		    DisplayName.SetDefault("Bête noire");
			
		    
            Tooltip.SetDefault("Once used by the nightmare god to make monsters real\nSummons nightmare monoliths to torture your enemys");
			
		}



		public override void SetDefaults()

		{

			item.damage = 150;

			item.summon = true;

			item.mana = 1;

			item.width = 26;

			item.height = 28;

			item.useTime = 36;

			item.useAnimation = 36;

			item.useStyle = 1;

			item.noMelee = true;

			item.knockBack = 3;
			
			item.value = Item.buyPrice(1, 0, 0, 0);

			item.rare = 9;

			item.UseSound = SoundID.Item44;

			item.shoot = mod.ProjectileType("NMWisp");

			item.shootSpeed = 10f;

			item.buffType = mod.BuffType("NMWisp");	//The buff added to player after used the item

			item.buffTime = 3600;				//The duration of the buff, here is 60 seconds

		}

		

		public override bool AltFunctionUse(Player player)

		{

			return true;

		}

		

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

		{

			return player.altFunctionUse != 2;

		}

		

		public override bool UseItem(Player player)

		{

			if(player.altFunctionUse == 2)

			{

				player.MinionNPCTargetAim();

			}

			return base.UseItem(player);

		}
        public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoonlordTurretStaff, 1);
			recipe.AddIngredient(ItemID.RavenStaff, 1);
			recipe.AddIngredient(ItemID.ImpStaff, 1);
			recipe.AddIngredient(ItemID.SpiderStaff, 1);
			recipe.AddIngredient(ItemID.OpticStaff, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 10);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(null,"NitmarBarItem", 10);
			recipe.AddIngredient(null,"MenancingFantasy", 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
		
    }

}