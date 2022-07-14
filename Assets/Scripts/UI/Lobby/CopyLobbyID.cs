using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLobbyID : MonoBehaviour
{
    public RoomManager rooms;

    public void CopyToClipboard()
    {
        rooms = FindObjectOfType<RoomManager>();
        GUIUtility.systemCopyBuffer = rooms.lobbyID.ToString();
    }

}
