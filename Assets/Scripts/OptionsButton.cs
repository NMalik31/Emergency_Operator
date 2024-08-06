using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    public GameObject IncomingCallCanvas;
    public GameObject AnswerCallCanvas;
    public GameObject CallOptionsCanvas;

    public void Option()
    {
        IncomingCallCanvas.SetActive(true);
        AnswerCallCanvas.SetActive(false);
        CallOptionsCanvas.SetActive(false);
    }
}
