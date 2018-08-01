using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityScript;
namespace AntiNoscopeLSD
{
    public class AntiNoscopeLSD : BaseScript
    {

        public AntiNoscopeLSD()
            : base()
        {

        }

        public override void OnPlayerDamage(Entity player, Entity inflictor, Entity attacker, int damage, int dFlags, string mod, string weapon, Vector3 point, Vector3 dir, string hitLoc)
        {
            try
            {
                if (player.GetField<string>("sessionteam") != attacker.GetField<string>("sessionteam"))
                {
                    if (weapon.Contains("scope") && mod != "MOD_MELEE")
                    {
                        if (attacker.Call<float>("playerads") == 0)
                        {
                            player.Health += damage;
                            attacker.Call("iprintlnbold", "^0L^1S^3D^2-AntiNoscope^7: Noscope are not allow!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                
            }
            
        }

    }
}
