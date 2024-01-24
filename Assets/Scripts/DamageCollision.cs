using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            if (!Timer.hasBeenDamagedRecently)
            {
                Timer.timer -= 5;
                Timer.hasBeenDamagedRecently = true;
            }
        }
    }
}
