using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBlockBottom : MonoBehaviour
{
    bool rotate = false;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rotate == true)
        {
            float targetAngle = 180f;
            player.transform.Rotate(new Vector3(0 ,0, targetAngle));
            if(player.transform.rotation.z == targetAngle)
            {
                rotate = false;
            }
            rotate = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = -3;
            rotate = true;
        }
    }
}
