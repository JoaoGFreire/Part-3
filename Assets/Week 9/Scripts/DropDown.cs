using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    Merchant Mvillager;
    Archer Avillager;
    public void dropdownSelection(Int32 value)
    {
        Debug.Log(dropdown.options[value].text);
        if (dropdown.options[value].text == "Merchant")
        {
            //CharacterControl.SetSelectedVillager( Mvillager);
            Debug.Log("it works");
        }
        if(dropdown.options[value].text == "Archer")
        {
            Debug.Log("it works");
            //CharacterControl.SetSelectedVillager(Avillager);
        }
    }
}
