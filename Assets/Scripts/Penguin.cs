using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Penguin : Animal
{
    // POLYMORPHISM
    private float speedMultiplier = 2;
    protected override void DoAction()
    {
        // penguin sprints during 4.5 seconds
        Speed *= speedMultiplier;
        StartCoroutine(WaitForRun());
    }
    IEnumerator WaitForRun(){
        yield return new WaitForSeconds(4.5f);
        Speed /= speedMultiplier;
    }
}
