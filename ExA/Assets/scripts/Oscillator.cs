using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 *  This component moves its object right and left like an Oscillator by given speed and range.
 */
public class Oscillator : MonoBehaviour
{
    private Vector3 startPosition;

    [Tooltip("Scale range in meters from the start position of the object")]
    [SerializeField]
    float range = 15f;

    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float speed = 50f;

    [Tooltip("Scale of the object in all axis")]
    [SerializeField]
    float scale = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position; //Get the start position
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scale, scale, scale); //update the scale by player
        /**
         *  use sin func to change position by given speed and range
         *  We multple the time by (speed / range) because we wont that the speed will not be depend on the range 
         *  (if we multiple just by speed when the range will change the object will change the speed)
         *  We multiple the sin func resault by the range because the sin func return range of (-1,1)
         */
        transform.position = startPosition + new Vector3(Mathf.Sin((speed / range) * Time.time) * range, 0.0f, 0.0f);
    }
}
