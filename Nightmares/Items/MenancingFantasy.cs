using Terraria.ModLoader;
using Terraria.ID;
namespace Nightmares.Items
{
    public class MenancingFantasy : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Menancing Fantasy");
			Tooltip.SetDefault("Dream. Horror. Phantasm. Ordeal. Illusion. Hallucination. Vision. Torment. Torture.");
		}
		public override void SetDefaults()
        {
			item.width = 12;
			item.height = 12;
			item.value = 10000;
			item.rare = 11;
			item.autoReuse = true;
		    item.consumable = false;
			item.maxStack = 1;
        }
        public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"NitmarBarItem", 6);
			recipe.AddIngredient(ItemID.SoulofNight, 6);
			recipe.AddIngredient(ItemID.SoulofFright, 6);
			recipe.AddIngredient(null,"SleepyPandemonium", 1);
			recipe.AddIngredient(null,"NightmarePrison", 1);
			recipe.AddIngredient(null,"SlumberDisruption", 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
		
    }

}