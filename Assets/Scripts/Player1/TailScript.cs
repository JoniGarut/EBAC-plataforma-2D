using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailScript : MonoBehaviour
{
    public GameObject anchorage;
    public Vector2 anchorPosition;

        // Update is called once per frame
    public void Update()
    {
        anchorage.transform.position = transform.TransformPoint(anchorPosition);
    }
}
