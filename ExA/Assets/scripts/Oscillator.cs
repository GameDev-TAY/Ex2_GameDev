using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 *  This component moves its object right and left like an Oscillator by given speed and range.
 */
public class Oscillator : MonoBehaviour
{
    private Vector3 startPosition;
    float startX;

    [SerializeField]
    float range = 15f;

    [SerializeField]
    float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position; //Get the start position
        startX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position.x = startX + Mathf.Sin((speed / range) * Time.time) * range;
        //transform.position = startPosition + new Vector3(Mathf.Sin((speed / range) * Time.time) * range, 0.0f, 0.0f); //use sin func to change position by given speed and range
    }
}
