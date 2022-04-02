using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseController : MonoBehaviour
{
    public float Speed = 1f;
    bool flightDirection;
    public float minFlightHeight = 0f;
    public float maxFlightHeight = 4f;
    public float flightStartRandomRange = 10f;
    public float screenHalfWidth = 8f;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartFlight();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + Speed*Time.deltaTime*(flightDirection ? -1: 1), transform.position.y);
        if (Mathf.Abs(transform.position.x) > screenHalfWidth) StartFlight();
    }


    void StartFlight()
    {
        flightDirection = Random.Range(0, 2) == 0;


        //fly right
        if (flightDirection == false)
        {
            spriteRenderer.flipX = true;
            transform.position = new Vector2(Random.Range(-screenHalfWidth, -(screenHalfWidth + flightStartRandomRange)), Random.Range(minFlightHeight, maxFlightHeight));
        }
        else
        {
            spriteRenderer.flipX = false;
            transform.position = new Vector2(Random.Range(screenHalfWidth, screenHalfWidth + flightStartRandomRange), Random.Range(minFlightHeight, maxFlightHeight));
        }

    }
}
