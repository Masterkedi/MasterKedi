using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScr : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    private void Start()
    {
        int random=Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[random]);
    }
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));
    }
}
