using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public bool wall;
    public bool springboard;
    public bool milk;

    public GameObject Wall;
    public GameObject Springboard;
    public GameObject Milk;
    

    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name == "TheOrb")
        {
            collision.gameObject.GetComponent<CharacterController>().Move(new Vector3(0,5,0));
            Debug.Log("Boing!");
        }

    }
}
