using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class objectSpawn : MonoBehaviourPunCallbacks
{
    [SerializeField]
    GameObject spawnningObject;
   // public GameObject cameraRef;
    public void spawn()/*GameObject spawningObject)*/
    {
        photonView.RPC("Spawning", RpcTarget.All /*, spawningObject*/);   
    }

    [PunRPC]
    void Spawning()/* GameObject spawnningObject)*/
    {
        Instantiate(spawnningObject, gameObject.transform.position + new Vector3(0, 0, 3f), Quaternion.identity);
    }

}
