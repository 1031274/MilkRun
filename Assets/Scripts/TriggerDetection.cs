using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDetection : MonoBehaviour
{
    public bool Checkpoint_00=true;
    public bool Checkpoint_01=false;

   void OnTriggerEnter(Collider collision)
   {
        if(collision.gameObject.name=="Entity_Player")
        {
            if(Checkpoint_00==true)
            {
                SceneManager.LoadScene("World_Stage_Zero");
            }
            if(Checkpoint_01==true)
            {
                Debug.Log("This Doesn't Exist.");
            }
        }
   }
}
