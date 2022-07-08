using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   [SerializeField] private Transform player;
   [SerializeField] private Transform respawnPoint;

   private void Update()
   {
      if (Input.GetButtonDown("r"))
      {
         player.transform.position = respawnPoint.transform.position;
         Debug.Log("button pressed");
      }
   }
}
