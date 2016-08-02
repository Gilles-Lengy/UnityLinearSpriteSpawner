using UnityEngine;
using System.Collections;

public class LinearSpritesSpawner2D : MonoBehaviour {

    public GameObject spriteToDuplicate;

    // Use this for spawning
    void Start()
    {
        Vector3 currentPosition = spriteToDuplicate.transform.position;
        for (int i = 0; i < 3; i++)
        {
            GameObject.Instantiate(spriteToDuplicate, currentPosition, Quaternion.identity);
            currentPosition += new Vector3(4f, 0f, 0f);
        }
    }
}
