using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

public class GUIManager_Dragon : GUIManager
{
    [Header("Bindings")]
    /// the stamina bar
    [Tooltip("the stamina bar")]
    public MMProgressBar[] StaminaBars;
    
    public virtual void SetStaminaBar(bool state, string playerID)
    {
        if (StaminaBars == null)
        {
            return;
        }

        foreach (MMProgressBar staminaBar in StaminaBars)
        {
            if (staminaBar != null)
            { 
                if (staminaBar.PlayerID == playerID)
                {
                    staminaBar.gameObject.SetActive(state);
                }					
            }
        }	        
    }
    
    public virtual void UpdateStaminaBar(float currentStamina,float minStamina,float maxStamina,string playerID)
    {
        if (StaminaBars == null) { return; }
        if (StaminaBars.Length <= 0)	{ return; }

        foreach (MMProgressBar staminaBar in StaminaBars)
        {
            if (staminaBar == null) { continue; }
            if (staminaBar.PlayerID == playerID)
            {
                staminaBar.UpdateBar(currentStamina,minStamina,maxStamina);
            }
        }

    }
}
