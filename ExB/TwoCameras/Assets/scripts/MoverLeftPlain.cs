using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object as long as the [W,A,S,D] keys is hold pressed.
 */
public class MoverLeftPlain : MonoBehaviour
{
    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        float toAdd = speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, toAdd, 0);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0, -toAdd, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(toAdd, 0, 0);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-toAdd, 0, 0);
        }
    }
}
