using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SquareManager : MonoBehaviour
{
    [FormerlySerializedAs("square")] [SerializeField] private Object tile;
    [SerializeField] private float spacing = 3;
    [SerializeField] private int xNum, yNum;
    [SerializeField] private float xPad, yPad;

    private List<Object> _tiles = new List<Object>();

    // Start is called before the first frame update
    void Start()
    {
        GenerateTiles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void GenerateTiles()
    {
        // -7 <= x <= 7, -2 <= y <= 4
        for (int x = 0; x < xNum; x++)
        {
            for (int y=0; y< yNum; y++)
            {
                float xPos = x / spacing + xPad;
                float yPos = y / spacing + yPad;
                Vector3 position = new Vector3(xPos, yPos, 0);
                var newTile = Instantiate(tile, position, Quaternion.identity, transform);

                _tiles.Add(newTile);
            }
        }    
    }

    private void Select()
    {
        
    }
}
