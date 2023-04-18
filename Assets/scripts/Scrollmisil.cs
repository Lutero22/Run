using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollmisil : MonoBehaviour
{
    private float VelocidadScroll = 1f;

    void Update()
    {
        if (transform.position.x < 5)
        {
            if (transform.position.y > 0)
            {
                transform.Translate(Vector2.down * VelocidadScroll * Time.deltaTime);
            }

            else
            {
                transform.Translate(Vector2.up * VelocidadScroll * Time.deltaTime);
            }
        }
        
    }
}
