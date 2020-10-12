using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollect : MonoBehaviour
{
    public AudioClip saw;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()  //Plays Sound Whenever collision detected
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
