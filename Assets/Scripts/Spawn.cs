using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Spawn : MonoBehaviour
{
    public float hallWidth
    {
        get; private set;
    }
    public float hallHeight
    {
        get; private set;
    }

    public int startRow
    {
        get; private set;
    }
    public int startCol
    {
        get; private set;
    }
    public GameObject player;
    public float minX, minY, maxX, maxY, minZ, maxZ;
    // Start is called before the first frame update
    void Start()
    {

        Vector2 randomPosition = new Vector3(Random.Range(minX, minY), Random.Range(maxX, maxY), Random.Range(minZ, maxZ));
        
        PhotonNetwork.Instantiate(player.name, randomPosition, Quaternion.identity);
    }
}
