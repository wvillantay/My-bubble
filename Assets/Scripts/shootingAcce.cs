using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingAcce : MonoBehaviour
{
   public GameObject shootingItem;
   public Transform shootingPoint;

   public bool canShoot = true;

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Return))
      {
         SShoot();
      }
   }
   void SShoot()
   {
      if (!canShoot)
         return;
      GameObject si = Instantiate(shootingItem, shootingPoint);
      si.transform.parent = null;
   }
}
