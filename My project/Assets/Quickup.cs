using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quickup : MonoBehaviour


{
    // Start is called before the first frame update
   public void OnCollisionEnter (Collision collision)
   {
        Destroy(gameObject);
   }
}
