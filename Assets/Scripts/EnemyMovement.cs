using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f;
    public float delta = 5f;
    public float offset = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(speed * Time.time, delta);
        Vector3 pos = new Vector3(transform.position.x, y+offset, transform.position.z);
        transform.position = pos;
    }
}
