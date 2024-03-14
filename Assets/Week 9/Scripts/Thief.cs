using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform sp;
    public Transform sp2;

    protected override void Attack()
    {
        speed = 30;
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(movement.magnitude <0.1)
        {
            speed = 3;
        }
        base.Attack();
        Instantiate(daggerPrefab, sp.position, sp.rotation);
        Instantiate(daggerPrefab, sp2.position, sp2.rotation);
        //speed = 3;
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
