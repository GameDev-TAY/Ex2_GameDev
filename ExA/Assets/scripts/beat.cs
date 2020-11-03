using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component enlarges and reduce it's object like a beating heart.
 */
public class beat : MonoBehaviour
{
    [Tooltip("The Scale to start the beat")]
    [SerializeField]
    float startScale;

    [Tooltip("Scale range of radius in meters from the center of the object")]
    [SerializeField]
    float range = 0.3f;

    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startScaleVec = new Vector3(startScale, startScale, startScale); //update the scale by player
        /**
         *  use sin func to change position by given speed and range
         *  We multple the time by (speed / range) because we wont that the speed will not be depend on the range 
         *  (if we multiple just by speed when the range will change the object will change the speed)
         *  We multiple the sin func resault by the range because the sin func return range of (-1,1)
         */
        float toChange = (Mathf.Sin((speed / range) * Time.time) * range);
        transform.localScale = startScaleVec + new Vector3(toChange, toChange, 0.0f );
    }
}
