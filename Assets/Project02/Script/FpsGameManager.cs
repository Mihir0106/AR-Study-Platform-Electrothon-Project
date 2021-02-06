using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FpsGameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnHandler;

    //public GameObject ObjectParent;

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            if (PhotonNetwork.IsConnectedAndReady)
            {
                int randomPoint = Random.Range(-2, 2);
                PhotonNetwork.Instantiate(spawnHandler.name, spawnHandler.transform.position/*new Vector3(randomPoint, 0f, randomPoint)*/, Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
