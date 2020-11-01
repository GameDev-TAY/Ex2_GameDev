using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component enlarges and reduce it's object like a beating heart.
 */
public class beat : MonoBehaviour
{
    private Vector3 startScale;

    [SerializeField]
    float range = 0.3f;

    [SerializeField]
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float toChange = (Mathf.Sin((speed / range) * Time.time) * range);
        transform.localScale = startScale + new Vector3(toChange, toChange, 0.0f );
    }
}
