using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_arrow : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDisable;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CarPos"))
        {
            objectToDisable.SetActive(false);
            objectToActivate.SetActive(true);
            
        }
    }
}
