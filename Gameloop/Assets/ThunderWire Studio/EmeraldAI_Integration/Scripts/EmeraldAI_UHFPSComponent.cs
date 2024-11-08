/*using UnityEngine;
using UHFPS.Runtime;
using Newtonsoft.Json.Linq;
using ThunderWire.Attributes;
using EmeraldAI;

namespace UHFPS.Integrations.EmeraldAI
{
    [InspectorHeader("Emerald AI (UHFPS Component)")]
    [HelpBox("Allows the UHFPS Player to damage Emerald AI characters. Place this script under the Emerald AI System component.")]
    public class EmeraldAI_UHFPSComponent : MonoBehaviour, ISaveable, IDamagable
    {
        private EmeraldAISystem emeraldAI;

        private int CurrentHealth => emeraldAI.CurrentHealth;

        private void Awake()
        {
            emeraldAI = GetComponent<EmeraldAISystem>();
        }

        public void ApplyDamageMax(Transform sender = null)
        {
            if (CurrentHealth <= 0)
                return;

            emeraldAI.Damage(CurrentHealth, EmeraldAISystem.TargetType.Player, sender);
        }

        public void OnApplyDamage(int damage, Transform sender = null)
        {
            if (CurrentHealth <= 0)
                return;

            emeraldAI.Damage(damage, EmeraldAISystem.TargetType.Player, sender);
        }

        public void OnLoad(JToken data)
        {
            bool isDead = (bool)data["IsDead"];
            gameObject.SetActive(!isDead);
        }

        public StorableCollection OnSave()
        {
            return new StorableCollection()
            {
                { "IsDead", emeraldAI.IsDead }
            };
        }
    }
}*/