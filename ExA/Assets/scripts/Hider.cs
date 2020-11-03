using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  This component hide and reveal its object by a pressing H key.
 */
public class Hider : MonoBehaviour
{
    private Renderer rend;

    [Tooltip("Scale of the object in all axis")]
    [SerializeField]
    float scale = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scale, scale, scale); //update the scale by player
        if (Input.GetKeyDown(KeyCode.H)) { //hide and reveal its object by a pressing H key
            rend.enabled = !rend.enabled;
        }
    }
}
