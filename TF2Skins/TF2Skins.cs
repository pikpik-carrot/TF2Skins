using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace TF2Skins
{
    public class TF2Skins : ModBehaviour
    {

        public interface ISkinChanger
        {
            void RegisterCustomSkin(ModBehaviour mod, string name, string assetName, string bundlePath, Vector3 cameraOffset, float colliderRadius, float colliderHeight, Vector3 colliderCenter);
        }

        public void Start()
        {
            var api = ModHelper.Interaction.TryGetModApi<ISkinChanger>("pikpik_carrot.SkinChanger");

            api.RegisterCustomSkin(this, "Demo (Red)", "Traveller_HEA_Player_Demo_Red", "Assets/Traveller_HEA_Player_Demo_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Engineer (Red)", "Traveller_HEA_Player_Engineer_Red", "Assets/Traveller_HEA_Player_Engineer_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Heavy (Red)", "Traveller_HEA_Player_Heavy_Red", "Assets/Traveller_HEA_Player_Heavy_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Medic (Red)", "Traveller_HEA_Player_Medic_Red", "Assets/Traveller_HEA_Player_Medic_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Pyro (Red)", "Traveller_HEA_Player_Pyro_Red", "Assets/Traveller_HEA_Player_Pyro_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Scout (Red)", "Traveller_HEA_Player_Scout_Red", "Assets/Traveller_HEA_Player_Scout_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Sniper (Red)", "Traveller_HEA_Player_Sniper_Red", "Assets/Traveller_HEA_Player_Sniper_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Soldier (Red)", "Traveller_HEA_Player_Soldier_Red", "Assets/Traveller_HEA_Player_Soldier_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Spy (Red)", "Traveller_HEA_Player_Spy_Red", "Assets/Traveller_HEA_Player_Spy_Red", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);

            api.RegisterCustomSkin(this, "Demo (Blue)", "Traveller_HEA_Player_Demo_Blue", "Assets/Traveller_HEA_Player_Demo_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Engineer (Blue)", "Traveller_HEA_Player_Engineer_Blue", "Assets/Traveller_HEA_Player_Engineer_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Heavy (Blue)", "Traveller_HEA_Player_Heavy_Blue", "Assets/Traveller_HEA_Player_Heavy_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Medic (Blue)", "Traveller_HEA_Player_Medic_Blue", "Assets/Traveller_HEA_Player_Medic_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Pyro (Blue)", "Traveller_HEA_Player_Pyro_Blue", "Assets/Traveller_HEA_Player_Pyro_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Scout (Blue)", "Traveller_HEA_Player_Scout_Blue", "Assets/Traveller_HEA_Player_Scout_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Sniper (Blue)", "Traveller_HEA_Player_Sniper_Blue", "Assets/Traveller_HEA_Player_Sniper_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Soldier (Blue)", "Traveller_HEA_Player_Soldier_Blue", "Assets/Traveller_HEA_Player_Soldier_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
            api.RegisterCustomSkin(this, "Spy (Blue)", "Traveller_HEA_Player_Spy_Blue", "Assets/Traveller_HEA_Player_Spy_Blue", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
        }
    }

}
