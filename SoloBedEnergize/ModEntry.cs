using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace SoloBedEnergize
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {

        private ModConfig Config;

        /*********
        ** Public methods
        *********/
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.OneSecondUpdateTicking += this.updateStaminaForFarmer;
            this.Config = this.Helper.ReadConfig<ModConfig>();
        }


        /*********
        ** Private methods
        *********/
        private void updateStaminaForFarmer(object sender, OneSecondUpdateTickingEventArgs e)
        {
            if (!Context.IsWorldReady)
                return;

            if (this.moreThanOnePlayerConnected())
            {
                return;
            } 
            else
            {
                if (Game1.player.isInBed)
                {
                    Game1.player.Stamina += (float)(Config.energyRate);
                    Game1.player.health += Config.healthRate;
                }
            }
        }

        // Want to use the default game recharging is more than one player connected
        private bool moreThanOnePlayerConnected()
        {
            if ((Game1.getOnlineFarmers().Count) > 1) 
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
