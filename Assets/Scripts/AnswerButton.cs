using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    public GameObject IncomingCallCanvas;
    public GameObject AnswerCallCanvas;
    public GameObject CallOptionsCanvas;

    public void Answer()
    {
        IncomingCallCanvas.SetActive(false);
        CallOptionsCanvas.SetActive(true);
    }
}
