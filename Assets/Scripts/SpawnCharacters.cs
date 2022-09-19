using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacters : MonoBehaviour
{
    public GameObject[] characterprefabs;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        int selectedcharacter = PlayerPrefs.GetInt("selectedcharacter");
        GameObject prefab = characterprefabs[selectedcharacter];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
