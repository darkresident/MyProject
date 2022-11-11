using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Player target;
    private float offset;

    private void Awake()
    {
        offset = transform.position.y - target.transform.position.y;
    }

    void Update()
    {
        Vector3 curPos = transform.position;
        curPos.y = target.transform.position.y + offset;
        if (transform.position.y > curPos.y)
        {
            transform.position = curPos;
        }
        else return;
    }
}

}
