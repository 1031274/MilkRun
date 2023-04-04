using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    public GameObject platform_1;

   void OnTriggerEnter(Collider collision)
   {
        if(collision.gameObject.name == "TheOrb")
        {
            platform_1.SetActive(true);
            Debug.Log("Hey Sometihing happened, what is is, we don't know. But it happened!");
        }
   }
}
