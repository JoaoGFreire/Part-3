using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Sceptile : Pokemon
{
    // Start is called before the first frame update
    public GameObject Leaves;
    public Transform sp;
    public Slider HealthBarS;
    public TMP_Text HealthBarTextS;
    Coroutine SpecialAttack;
    void Start()
    {
        Health = 100;
        HealthBarSetup();

        StartCoroutine(LeafStorm());
    }
    protected override void HealthBarSetup()
    {
        HealthBarS.maxValue = 100;
        HealthBarTextS.text = "Sceptile HP: " + Health.ToString();
    }

    public IEnumerator LeafStorm()
    {
        while (Health > 0)
        {
            Instantiate(Leaves, sp.position, sp.rotation);
            yield return new WaitForSeconds(5f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
