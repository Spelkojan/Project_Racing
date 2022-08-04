using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_Checkpoint : MonoBehaviour
{
    // public GameObject enableTargetObject;

    public GameObject objectToDisable;
    public GameObject objectToActivate;

    private IEnumerator ActivationRoutine()
     {        
         //Wait for 14 secs.
         yield return new WaitForSeconds(10);
 
         //Turn My game object that is set to false(off) to True(on).
         objectToDisable.SetActive(false);
         objectToActivate.SetActive(true);
         
     }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CarPos"))
        {
            StartCoroutine(ActivationRoutine());
            
            print("trigger entered");

            // new WaitForSeconds(10);
            // enableTargetObject.gameObject.SetActive(false);
            
        }
    }
}
