using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopterController : MonoBehaviour
{
    public float Speed = 1f;
    float Xpos;

    // Start is called before the first frame update
    void Start()
    {
        Xpos = -12f;
        transform.position = new Vector2(Xpos, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Xpos < 16f)
        {
            float dX = Speed * Time.deltaTime;
            Xpos += dX;
            transform.transform.Translate(dX * Vector2.right);
        }
    }
}
