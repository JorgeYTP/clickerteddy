using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{



    [SerializeField] private Texture2D CursorTexture;
    private Vector2 cursorHotspot; 
    // Start is called before the first frame update
    void Start()
    {
        cursorHotspot = new Vector2 (CursorTexture.width  / 2, CursorTexture.height / 2);
        Cursor.SetCursor(CursorTexture, cursorHotspot, CursorMode.Auto); 
    }   

}
