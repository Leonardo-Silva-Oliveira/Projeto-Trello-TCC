using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedcharacter = 0;

    public void RightButton(){
        characters[selectedcharacter].SetActive(false);
        selectedcharacter = (selectedcharacter + 1) % characters.Length;
        characters[selectedcharacter].SetActive(true);
    }
    public void LeftButton(){
        characters[selectedcharacter].SetActive(false);
        selectedcharacter--;
        if(selectedcharacter < 0){
            selectedcharacter += characters.Length;
        }
        characters[selectedcharacter].SetActive(true);
    }
    public void StartButton(){
        PlayerPrefs.SetInt("selectedcharacter", selectedcharacter);
        SceneManager.LoadScene("CenaJogo");
    }
}
