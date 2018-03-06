using Terraria.ModLoader;
using Terraria.ID;
namespace Nightmares.Items.Blocks
{
    public class NitmarBarItem : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nitmar Bar");
			Tooltip.SetDefault("Even more pure. Even more concentrated. Even more terrifying");
		}
		public override void SetDefaults()
        {
			item.width = 24;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 1000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		    item.consumable = true;
			item.createTile = mod.TileType("NitmarBarTile");
			item.maxStack = 99;
        }
        
		public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "NitmarOreItem", 4);
            r.AddTile(TileID.DemonAltar);
	        r.SetResult(this);
	        r.AddRecipe();
	    }
	}

}