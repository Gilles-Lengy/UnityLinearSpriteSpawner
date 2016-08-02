using UnityEngine;
using System.Collections;

public class LinearSpritesSpawner2D : MonoBehaviour {

    public GameObject spriteToDuplicate;
    public float startPositionX;
    public float StartPositionY;

    // Use this for spawning
    void Start()
    {
        Vector3 spritePosition = new Vector3(startPositionX, StartPositionY, 0f);
        for (int i = 0; i < 3; i++)
        {
            GameObject.Instantiate(spriteToDuplicate, spritePosition, Quaternion.identity);
            spritePosition += new Vector3(4f, StartPositionY, 0f);
        }
    }
}
