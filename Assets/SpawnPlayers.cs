using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class SpawnPlayers : MonoBehaviour
{

    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(-7.0f, -5.0f), 15.9f, -21.71f);
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
