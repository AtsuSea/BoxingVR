using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{

    public AudioSource hitSound;

    void Start()
    {
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Glove")
        {
            
            print(other.GetComponent<ControllerManager>().GetVelocityFloat());
            if(other.GetComponent<ControllerManager>().GetVelocityFloat() >= 40f)
            {
                hitSound.Play();
                Destroy(gameObject);
            }
        }
    }
    
}
