using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPositioner : MonoBehaviour
{
    private float deafultPosZ;
    private new Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.transform;
        deafultPosZ = transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.localPosition = new Vector3(0, 0, hit.distance * 0.95f);
        }
        else
        {
            transform.localPosition = new Vector3(0, 0, deafultPosZ);
        }
    }
}
