using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object as long as the arrow key is hold pressed.
 */
public class Mover : MonoBehaviour
{
    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        float toAdd = speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position += new Vector3(0, toAdd, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position += new Vector3(0, -toAdd, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(toAdd, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += new Vector3(-toAdd, 0, 0);
        }
    }
}
