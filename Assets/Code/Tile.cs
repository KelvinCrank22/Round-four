using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    void OnMouseEnter()
    {
        var _color = this.GetComponent<SpriteRenderer>().color;
        _color.a = .4f;
        this.GetComponent<SpriteRenderer>().color = _color;
    }
    void OnMouseExit()
    {
        var _color = this.GetComponent<SpriteRenderer>().color;
        _color.a = 1f;
        this.GetComponent<SpriteRenderer>().color = _color;
    }
}
