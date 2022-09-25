using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Rotate(0f, 0f, 1f);

    }

    public void QGame()
    {
        Application.Quit();
    }
}
