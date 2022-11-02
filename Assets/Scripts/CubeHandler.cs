using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandler : ObjectHandler
{
    public GameObject cube;

    // Update is called once per frame
    private void Update()
    {
        RotateObject();
    }

    private void OnMouseDown()
    {
        cube.SetActive(true);
    }
}
