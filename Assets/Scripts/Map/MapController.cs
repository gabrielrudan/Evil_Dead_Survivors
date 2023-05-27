using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    
    public List<GameObject> terrainChunks;
    public GameObject player;
    public float checkerRadius;
    Vector3 noTerrainPosition;
    public LayerMask terrainMask;
    public GameObject currentChunk;
    Player pm;

    [Header("Optimization")]
    public List<GameObject> spawnedChunks;
    public GameObject lastestChunk;
    public float maxOpDist; //precisa ser maior que a altura e a largura do tilemap
    float opDist;

    void Start()
    {
        pm = FindObjectOfType<Player>();
    }

    void Update()
    {
        ChunkChecker();
        ChunkOptimizer();
    }

    void ChunkChecker()
    {

        if(!currentChunk)
        {
            return;
        }

        if(pm.movementInput.x > 0 && pm.movementInput.y == 0) //right
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Right").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Right").position;
                SpawnChunk();
            }
        }

        else if(pm.movementInput.x < 0 && pm.movementInput.y == 0) //left
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Left").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Left").position;
                SpawnChunk();
            }
        }

        else if(pm.movementInput.x == 0 && pm.movementInput.y > 0) //up
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Up").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Up").position;
                SpawnChunk();
            }
        }

        else if(pm.movementInput.x == 0 && pm.movementInput.y < 0) //down
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Down").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Down").position;
                SpawnChunk();
            }
        }

        else if(pm.movementInput.x > 0 && pm.movementInput.y > 0) //right-up
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Right-Up").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Right-Up").position;
                SpawnChunk();
            }
        }

        else if(pm.movementInput.x > 0 && pm.movementInput.y < 0) //down-right
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Down-Right").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Down-Right").position;
                SpawnChunk();
            }
        }

        else if(pm.movementInput.x < 0 && pm.movementInput.y > 0) //up-left
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Up-Left").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Up-Left").position;
                SpawnChunk();
            }
        }

        else if(pm.movementInput.x < 0 && pm.movementInput.y < 0) //left-down
        {
            if(!Physics2D.OverlapCircle(currentChunk.transform.Find("Left-Down").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("Left-Down").position;
                SpawnChunk();
            }
        }
    }

    void SpawnChunk()
    {
        int rand = Random.Range(0, terrainChunks.Count);
        lastestChunk = Instantiate(terrainChunks[rand], noTerrainPosition, Quaternion.identity);
        spawnedChunks.Add(lastestChunk);
    }

    void ChunkOptimizer()
    {
        foreach (GameObject chunk in spawnedChunks)
        {
            opDist = Vector3.Distance(player.transform.position, chunk.transform.position);
            if(opDist > maxOpDist)
            {
                chunk.SetActive(false);
            }
            else
            {
                chunk.SetActive(true);
            }
        }
    }

}
