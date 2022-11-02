using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHandler : ObjectHandler
{
    public GameObject sphere;

    // Update is called once per frame
    private void Update()
    {
        RotateObject();
    }

    private void OnMouseDown()
    {
        sphere.SetActive(true);
    }
}
