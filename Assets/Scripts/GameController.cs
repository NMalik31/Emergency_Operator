using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public RoomNavigation roomNavigation;

    void FirstCall()
    {
        roomNavigation = GetComponent<RoomNavigation> ();
    }

    public void DisplayText()
    {
        string combinedText = roomNavigation.currentRoom.description + "\n";
    }
}
