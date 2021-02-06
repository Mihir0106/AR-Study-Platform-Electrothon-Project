using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class objectSpawn : MonoBehaviourPunCallbacks
{
    public GameObject spawnningObject;
    public GameObject cameraRef;
    public void spawn()
    {
        photonView.RPC("Spawning", RpcTarget.All);   
    }

    [PunRPC]
    void Spawning()
    {
        Instantiate(spawnningObject, cameraRef.transform.position + new Vector3(0, 0, 3f), Quaternion.identity);
    }

}
