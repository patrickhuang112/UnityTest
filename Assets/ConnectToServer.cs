using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); 
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public void CreateRoom()
    {
        Debug.Log("Creating room...");
        PhotonNetwork.CreateRoom("test1", new Photon.Realtime.RoomOptions { MaxPlayers = 4 });
    }

    public void JoinRoom()
    {
        Debug.Log("Joining room...");
        PhotonNetwork.JoinRoom("test1");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Scenes/Playground");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
