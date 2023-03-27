using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // Estas funciones sirven para caundo pulsamos play se desactiva este y se activa el pause y cuando pulsamos este último se vuelve a activar el play
    // Sirve para cuándo nos olvidemos que no exite el bool interactable de la componente button

    public Button playButton;
    public Button pauseButton;
    public void PlayButtonFunction()
    {
        playButton.interactable = false;
        pauseButton.interactable = true;
    }

    public void PauseButtonFunction()
    {
        playButton.interactable = true;
        pauseButton.interactable = false;
    }

    /*
    public void PlayPauseButtonFunction(bool playButtonHasBeenPressed) //Esta función fusiona las 2 funciones anteriores (Play and Pause button function)
    {
        playButton.interactable = !playButtonHasBeenPressed; // false
        pauseButton.interactable = playButtonHasBeenPressed; // true
    }
    */
}
