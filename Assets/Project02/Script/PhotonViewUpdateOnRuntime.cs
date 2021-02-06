using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonViewUpdateOnRuntime : MonoBehaviourPunCallbacks
{
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            gameObject.GetComponent<PhotonView>().ViewID = spawner.GetComponent<PhotonView>().ViewID;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
