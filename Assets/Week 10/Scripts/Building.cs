using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject targetpf;
    public GameObject barrelpf;
    public GameObject cratepf;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public AnimationCurve scaleUP;
    Coroutine Build;
    float interpolationRatio;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        Build = StartCoroutine(Build_C());
    }
    IEnumerator Build_C()
    {
        timer += 2 * Time.deltaTime;
        interpolationRatio = scaleUP.Evaluate(timer);
        Instantiate(targetpf,spawn1.position,spawn1.rotation);
        targetpf.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, interpolationRatio);
        yield return new WaitForSeconds(2f);
        Instantiate(barrelpf,spawn2.position,spawn2.rotation);
        barrelpf.transform.localScale = Vector3.Lerp(Vector3.zero,Vector3.one, interpolationRatio);
        //lerp...

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
