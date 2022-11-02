using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandler : MonoBehaviour
{
    public GameObject textScene;

    public virtual void RotateObject()
    {
        transform.Rotate(0.02f, 0.02f, 0.02f);
    }

    public virtual void DeactivateText()
    {
        textScene.SetActive(false);
    }

}
