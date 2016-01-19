using UnityEngine;
using System.Collections;
using System;

public class TiledBackground : MonoBehaviour {

    public int textureSize = 32; // SO this is the texture swize, remember best to keep adjusting texture in powewrs of two. Thats 32 pixels. We doing a pixel perfect game

    // SO stands to reason that to get the tiling right, pixels must fall properly into place  for native resolution. But to get the same look at other resolutions, must adjust the texture size

	// Use this for initialization
	void Start () { // Note, the below code is put here and not in awak, because the PixelPerefct Camera might have nit setup up properly yet and we using values from there
        var newWidth = Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
        var newHeight = Mathf.Ceil(Screen.height / (textureSize * PixelPerfectCamera.scale));
        Debug.Log("New width is " + newWidth + " and new height is " + newHeight);
        transform.localScale = new Vector3((newWidth * textureSize), (newHeight * textureSize), 1); // Note z cant be zero, thats why its a a Vector3. We still in a 3D world

        GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
