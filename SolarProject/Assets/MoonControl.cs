using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoonControl : MonoBehaviour
{
    public GameObject earth = default;
    private float rotateSpeed = 16.655f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(earth.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
