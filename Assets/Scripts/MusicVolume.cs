using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    public GameObject cam;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = cam.GetComponent<AudioSource>(); // Esta linea ha de ser en el Start porque el AudioSource es ajeno al objeto cam y si lo puesi�rmaos en el Awake podr�a fallar
                                                        // = el objeto que tiene el audiosource accedemos a este

        scaleCube = cube.transform.localScale;
    }                                                   


    public void VolumeMusic(float value)
    {
        _audioSource.volume = value;  // = el objeto que ya tiene acceso el audiosource, ahora accedemos a su componente volumen con la variable creada
                                     // Si asignamos esta funci�n al slider, al dar PLAY y mirar el volumen del audiosource, este se mover� cuando movamos el slider
    }

    // Ejercicio scala cubo con slider

    public GameObject cube;
    private Vector3 scaleCube;

    public void CubeScale(int value)
    {
        
    }
}
