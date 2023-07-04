using UnityEngine;

public class EarthControl : MonoBehaviour
{
    public GameObject sun = default;
    private float rotateSpeed = 16.70f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
