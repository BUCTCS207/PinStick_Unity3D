using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaself : MonoBehaviour
{

    public float speed = 90;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
    }
}
