using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSoundScript : MonoBehaviour
{
    
        public AudioSource ChickenEf;
        private void OnCollisionEnter(Collision collision)
        {
        ChickenEf.Play();
        }

}
