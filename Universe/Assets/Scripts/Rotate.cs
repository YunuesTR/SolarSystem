using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 5.0f; // D�nme h�z�n� buradan ayarlayabilirsiniz

    void Start()
    {
        
    }

    void Update()
    {
   
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
