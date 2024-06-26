using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Garchomp : Pokemon
{
    public Slider HealthBarG;
    public TMP_Text HealthTextG;
    // Start is called before the first frame update
    void Start()
    {
        Health = 150;
        HealthBarSetup();    
    }
    protected override void HealthBarSetup()
    {
        HealthBarG.maxValue = 150;
        HealthTextG.text = "Garchomp HP: " + Health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health == 0) 
        {
            SceneController.DeathScene();
        }
    }

   public void Heal()
    {
        if(Health >= 150)
        {
            Health = 150;
        }
        else
        {
            Health += 10;
            HealthBarG.value -= 10;
            HealthTextG.text = "Garchomp HP: " + Health.ToString();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health -= 10;
        HealthBarG.value += 10;
        HealthTextG.text = "Garchomp HP: " + Health.ToString();
    }
}
