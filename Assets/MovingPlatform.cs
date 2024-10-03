using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour

{
    public Transform start;
    public Transform end;

    public float speed = 1f;

    private float t = 0.0f;
    private bool movingForward = true;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, t);

        if (movingForward)
        {
            t += Time.deltaTime * speed;
            if(t > 1.0f)
            {
                movingForward = false;
            }
        }
        else
        {
            t -= Time.deltaTime * speed;
            if(t < 0.0f)
            {
                movingForward = true;
            }
        }
    }
}
