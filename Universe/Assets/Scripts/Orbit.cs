using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Orbit : MonoBehaviour
{
    public Transform center; // Y�r�ngenin merkez noktas� (�rne�in g�ne�) i�in ba�ka bir nesneye referans.
    public float orbitSpeed = 2.0f; // Y�r�nge etraf�nda d�nme h�z�.

    void Update()
    {
        // "RotateAround" fonksiyonu, bu nesneyi (�rne�in gezegen) belirtilen merkez noktas� etraf�nda d�nd�r�r.
        // Bu d�nme i�lemi, "orbitSpeed" de�i�keni ile belirlenen h�zda ger�ekle�ir ve "Time.deltaTime" ile s�rekli h�zl� bir d�n�� sa�lan�r.
        // "Vector3.up" kullanarak y�r�ngenin d�zlemi etraf�nda d�nme yap�l�r, bu da gezegenin d�zlemde d�nmesini sa�lar.
        transform.RotateAround(center.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
