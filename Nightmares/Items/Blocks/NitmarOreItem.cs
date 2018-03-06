using Terraria.ModLoader;
using Terraria.ID;
namespace Nightmares.Items.Blocks
{
    public class NitmarOreItem : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nitmar Ore");
			Tooltip.SetDefault("Pure, concentrated Nightmares. But how did they get here?");
		}
		public override void SetDefaults()
        {
			item.width = 12;
			item.height = 12;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 1000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		    item.consumable = true;
			item.createTile = mod.TileType("NitmarOreTile");
			item.maxStack = 999;
        }

    }

}