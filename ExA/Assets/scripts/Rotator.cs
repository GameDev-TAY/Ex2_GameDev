using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  This component rotate its object Counterclockwise by given speed.
 */
public class Rotator : MonoBehaviour
{
    [Tooltip("Rotation speed in degrees per second")]
    [SerializeField]
    float speedRotate = 180f;

    [Tooltip("Scale of the object in all axis")]
    [SerializeField]
    float scale = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scale, scale, scale); //update the scale by player
        transform.Rotate(new Vector3(0, 0, speedRotate * Time.deltaTime)); //rotate by given speed
    }
}
