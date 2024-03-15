using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CharacterControl : MonoBehaviour
{
    public TMP_Text villagerType;
    //public ChestType type;
    public static Villager SelectedVillager { get; private set; }
    private void Update()
    {

        villagerType.text = "none selected";
        if (SelectedVillager.CanOpen() == ChestType.Merchant)
        {
            villagerType.text = "Merchant";
        }
        if(SelectedVillager.CanOpen() == ChestType.Archer)
        {
            villagerType.text = "Archer";
        }
        if(SelectedVillager.CanOpen() == ChestType.Thief)
        {
            villagerType.text = "Thief";
        }
        
    }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }
    
    
}
