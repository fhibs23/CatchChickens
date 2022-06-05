using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSoundScript : MonoBehaviour
{
    Animator anim;
        public AudioSource ChickenEf;
        private void OnCollisionEnter(Collision collision)
        {
        ChickenEf.Play();
        }
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("WaitTrigger"))
        {
            ChickenEf.Play();
        }
    }
}
