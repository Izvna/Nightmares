using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;


namespace Nightmares.Tiles

{

    public class NitmarBarTile : ModTile

    {

        public override void SetDefaults()

        {

            Main.tileSolid[Type] = true; // Is the tile solid
           
		    Main.tileFrameImportant[Type] = true;
           
		    TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            
			TileObjectData.addTile(Type);
	   
            drop = mod.ItemType("NitmarBarItem"); // What item drops after destorying the tile

            ModTranslation name = CreateMapEntryName();

            AddMapEntry(new Color(0, 0, 0)); // Colour of Tile on Map

            minPick = 0; // What power pick minimum is needed to mine this block.

        }

    }

}