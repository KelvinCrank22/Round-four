using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePrefab;
    public List<Sprite> tileFaces;
    public List<Vector2> path;

    void Start()
    {
        transform.position = new Vector3(-(_width/2), -(_height/2), transform.position.z);
        GenerateGrid();
    }

    Sprite rightSprite(int x, int y)
    {
        int _lengthIndex = (x*_width) + y;
        return tileFaces[_lengthIndex % tileFaces.Count];
    }
        
    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var pos = new Vector3(x-(((float)_width)/2.0f) + .5f, y-(((float)_height)/2.0f) + .5f);
                var nextTile = Instantiate(_tilePrefab, pos, Quaternion.identity);
                nextTile.name = $"Tile {x} {y}";
                nextTile.GetComponent<SpriteRenderer>().sprite = rightSprite(x, y);
                nextTile.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }
}
