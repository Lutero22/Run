using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminar : MonoBehaviour
{

    void Start()
    {
        CircleCollider2D ColliderSuelo = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if (transform.position.x < -14)
        {
            Destroy(this.gameObject);
        }
    }
}

