using UnityEngine;
using System.Collections;

public class LinearSpritesSpawner2D : MonoBehaviour {

    public GameObject spriteToDuplicate;
    public float startPositionX;
    public float StartPositionY;

    // Use this for spawning
    void Start()
    {
        Vector2 spritePosition = new Vector2(startPositionX, StartPositionY);
        for (int i = 0; i < 3; i++)
        {
            GameObject.Instantiate(spriteToDuplicate, spritePosition, Quaternion.identity);
            spritePosition += new Vector2(4f, StartPositionY);
        }
    }
}
