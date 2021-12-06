using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeFly : MonoBehaviour
{
    public Vector3 move;
    public Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition -= move;

        if (transform.localPosition.x < 5.80)
        {
            transform.Rotate(rotate);
        }
    }
}
