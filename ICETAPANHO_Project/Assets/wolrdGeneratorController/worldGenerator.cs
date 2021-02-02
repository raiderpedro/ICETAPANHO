using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class worldGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

public const int chunkLenght = 40;     
public Tilemap[] chunk = new Tilemap[3];     
private int posUltimo;     
private int limite = 10, i = 0;

void Update()
    {

        while (i < limite)
        {
            int chunkId = Random.Range(0, chunk.Length);
            Tilemap objeto;

            objeto = Instantiate(chunk[chunkId], new Vector3(posUltimo, 0, 0), Quaternion.identity);

            objeto.transform.parent = this.transform;

            posUltimo += chunkLenght;

            i++;
        }

    }

}
