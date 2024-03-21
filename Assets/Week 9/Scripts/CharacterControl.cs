using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CharacterControl : MonoBehaviour
{
    public TMP_Text villagerType;
    public TMP_Dropdown dropdown2;

    public Merchant merc;
    public Archer arch;
    public Thief thie;
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
        //if(SelectedVillager != null)
        //{
        //    villagerType.text = SelectedVillager.GetType().ToString();
        //}
        //villagerType.text = SelectedVillager.GetType().ToString();
        
    }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        //Instance.villagerType.text = villager.ToString();
    }

    public void dropdownSelection(Int32 value)
    {
        Debug.Log(dropdown2.options[value].text);
        if (dropdown2.options[value].text == "Merchant")
        {
            SetSelectedVillager(merc);
            Debug.Log("it works");
        }
        if (dropdown2.options[value].text == "Archer")
        {
            Debug.Log("it works");
            SetSelectedVillager(arch);
        }
        if (dropdown2.options[value].text == "Thief")
        {
            Debug.Log("Thief Selected");
            SetSelectedVillager(thie);
        }
    }


}
