using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineReached : MonoBehaviour
{
    public GameObject player;
    private Health healthPlayer;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            healthPlayer.finishReached = true;
            Destroy(gameObject);
        }
    }
}
