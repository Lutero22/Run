using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetirFondo : MonoBehaviour
{
    private float AnchoSprite;

    void Start()
    {
        SpriteRenderer ColliderFondo = GetComponent<SpriteRenderer>();
        AnchoSprite = ColliderFondo.size.x;
    }

    void Update()
    {
        if (transform.position.x < -26)
        {
            transform.Translate(Vector2.right * 3f * AnchoSprite);
        }
    }
}
