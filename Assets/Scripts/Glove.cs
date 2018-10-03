using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glove : MonoBehaviour
{

    public AudioSource hitSound;

    void Start()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        print("ちょ！");
        if (other.gameObject.tag == "Target")
        {
            hitSound.Play();
            print("もちょ！");
        }
    }
}
