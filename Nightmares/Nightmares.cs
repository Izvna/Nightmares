using Terraria.ModLoader;

namespace Nightmares
{
	class Nightmares : Mod
	{
		public Nightmares()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
