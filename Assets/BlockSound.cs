using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour {

    public AudioClip blocksound;

    public AudioSource audioSource;

    // Use this for initialization
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "CubeTag")
            {
                audioSource.PlayOneShot(blocksound);
            }
            else if (other.gameObject.tag == "GroundTag")
            {
                audioSource.PlayOneShot(blocksound);
            }
        }
    
}
