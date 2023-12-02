using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Orbit : MonoBehaviour
{
    public Transform center; // Yörüngenin merkez noktasý (örneðin güneþ) için baþka bir nesneye referans.
    public float orbitSpeed = 2.0f; // Yörünge etrafýnda dönme hýzý.

    void Update()
    {
        // "RotateAround" fonksiyonu, bu nesneyi (örneðin gezegen) belirtilen merkez noktasý etrafýnda döndürür.
        // Bu dönme iþlemi, "orbitSpeed" deðiþkeni ile belirlenen hýzda gerçekleþir ve "Time.deltaTime" ile sürekli hýzlý bir dönüþ saðlanýr.
        // "Vector3.up" kullanarak yörüngenin düzlemi etrafýnda dönme yapýlýr, bu da gezegenin düzlemde dönmesini saðlar.
        transform.RotateAround(center.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
