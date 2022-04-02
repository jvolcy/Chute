using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperController : MonoBehaviour
{
    public GameObject Copter;
    bool startDrop = false;
    float dropRate = 1f;
    float yPos;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = Copter.transform.position;
            yPos = transform.position.y;
            startDrop = true;
            spriteRenderer.enabled = true;
        }

        if (startDrop)
        {
            transform.position = new Vector2(transform.position.x, yPos);
            yPos -= dropRate * Time.deltaTime;
        }
    }
}
