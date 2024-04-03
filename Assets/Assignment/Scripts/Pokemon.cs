using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Pokemon : MonoBehaviour
{
    // Start is called before the first frame update
    protected float Health;
    public static float Strength;

    public Slider HealthBar;
    public TMP_Text HealthText;
    
    
    void Start()
    {
        Health = 100;
        Strength = 10;
        HealthBarSetup();
    }
    protected virtual void HealthBarSetup()
    {
        HealthBar.maxValue = Health;
        HealthText.text = "HP: " + Health.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual float getHealth()
    {
        return Health;
    }
    public static float getStrength()
    {
        return Strength;
    }
}
