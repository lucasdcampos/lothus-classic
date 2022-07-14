using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class CreateAndJoimRooms : MonoBehaviourPunCallbacks
{
    public InputField joinInput;

    public GameObject lobbyMenu;
    public GameObject mainMenu;

    public int lobbyID;
    public Text idText;




    public void CreateRoom()
    {
        {
            lobbyID = Random.Range(1000000000, 2000000000);
            PhotonNetwork.CreateRoom(lobbyID.ToString());
        }

    }

    public void JoinRoom() { PhotonNetwork.JoinRoom(joinInput.text); }




    public override void OnJoinedRoom()
    {
        idText.text = lobbyID.ToString();
        lobbyMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        mainMenu.SetActive(true);
        lobbyMenu.SetActive(false);
    }

    public void StartGame()
    {
        print(PhotonNetwork.LevelLoadingProgress);
        PhotonNetwork.LoadLevel("Game");
    }
}
