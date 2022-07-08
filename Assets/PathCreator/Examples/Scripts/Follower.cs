using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
   public PathCreator NPC_car;
   public float speed = 5;
   private float distanceTravelled;

   private void Update()
   {
      distanceTravelled += speed + Time.deltaTime;
      transform.position = NPC_car.path.GetPointAtDistance(distanceTravelled);
      transform.rotation = NPC_car.path.GetRotationAtDistance(distanceTravelled);
   }
}
