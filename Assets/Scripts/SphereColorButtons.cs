using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SphereColorButtons : MonoBehaviour
{
    // Funciones botones - Cambio color

    public Material mat;
    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    public void Red()
    {
        mat.color = Color.red;
    }

    public void Blue()
    {
        mat.color = Color.blue;
    }

    public void Green()
    {
        mat.color = Color.green;
    }
}
