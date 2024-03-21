using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform sp;
    public Transform sp2;
    Coroutine dashing;

    protected override void Attack()
    {
        if (dashing != null)
        {
            StopCoroutine(dashing);
        }
        dashing = StartCoroutine(Dash());
    }
    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 10;
        while (speed > 3)
        {
            yield return null; //come back next frame
        }
        
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, sp.position, sp.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, sp2.position, sp2.rotation);
    }
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    public override string ToString()
    {
        return "Hi I'm Bill.";
    }
}
