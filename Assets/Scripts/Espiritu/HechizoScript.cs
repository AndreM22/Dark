using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HechizoScript : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rigidbody2D;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        DestroyEmbrujo();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rigidbody2D.velocity = direction * Speed;
    }

    public void setDirection(Vector2 d)
    {
        direction = d;
    }

    public void DestroyEmbrujo()
    {
        Destroy(gameObject,1f);
    }
}
