using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMocement : MonoBehaviour
{
    public Rigidbody2D player;
    public Rigidbody2D selfCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > 0.3)
        {
            selfCamera.position = new Vector2(player.position.x, player.position.y);
        }
        else
        {
            selfCamera.position = new Vector2(player.position.x, 0.3f);
        }
       
    }
}
