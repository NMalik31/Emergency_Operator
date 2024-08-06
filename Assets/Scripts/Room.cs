using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "OptionsText")]
public class Room : ScriptableObject
{
    [TextArea]
    public string description;
    public string roomName;
}
