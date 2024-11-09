/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;
using UHFPS.Runtime;

namespace EmeraldAI
{
    //This script will automatically be added to player targets. You can customize the DamagePlayerStandard function
    //or create your own. Ensure that it will be called within the SendPlayerDamage function. This allows users to customize
    //how player damage is received and applied without having to modify any main system scripts. The EmeraldComponent can
    //be used for added functionality such as only allowing blocking if the received AI is using the Melee Weapon Type.
    public class EmeraldAIPlayerDamage : MonoBehaviour
    {
        public List<string> ActiveEffects = new List<string>();
        public bool IsDead = false;

        public void SendPlayerDamage(int DamageAmount, Transform Target, EmeraldAISystem EmeraldComponent, bool CriticalHit = false)
        {
            //The standard damage function that sends damage to the Emerald AI demo player
            //DamagePlayerStandard(DamageAmount);

            //Creates damage text on the player's position, if enabled.
            if (GetComponent<EmeraldAI.Utility.TargetPositionModifier>() != null)
                CombatTextSystem.Instance.CreateCombatText(DamageAmount, new Vector3(transform.position.x, transform.position.y + GetComponent<EmeraldAI.Utility.TargetPositionModifier>().PositionModifier, transform.position.z), CriticalHit, false, true);
            else
                CombatTextSystem.Instance.CreateCombatText(DamageAmount, transform.position, CriticalHit, false, true);

            //Sends damage to another function that will then send the damage to the UHFPS player.
            DamageUHFPSPlayer(DamageAmount, Target);
        }

        /*
        void DamagePlayerStandard(int DamageAmount)
        {
            if (GetComponent<EmeraldAIPlayerHealth>() != null)
            {
                EmeraldAIPlayerHealth PlayerHealth = GetComponent<EmeraldAIPlayerHealth>();
                PlayerHealth.DamagePlayer(DamageAmount);

                if (PlayerHealth.CurrentHealth <= 0)
                {
                    IsDead = true;
                }
            }
        }
        */
/*
        void DamageUHFPSPlayer(int DamageAmount, Transform Target)
        {
            if(TryGetComponent(out PlayerHealth playerHealth) && !playerHealth.IsDead)
            {
                playerHealth.OnApplyDamage(DamageAmount, Target);
                IsDead = playerHealth.IsDead;
            }
        }
    }
}*/
