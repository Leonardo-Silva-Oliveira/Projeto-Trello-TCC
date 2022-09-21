using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public Text[] characternames;
    public int selectedcharacter = 0;
    public int selectednames = 0;

    public void Start(){
        characternames[0].enabled = true;
        characternames[1].enabled = false;
        characternames[2].enabled = false;
    }
    public void RightButton(){
        characternames[selectednames].enabled = false;
        characters[selectedcharacter].SetActive(false);
        selectednames = (selectednames + 1) % characternames.Length;
        selectedcharacter = (selectedcharacter + 1) % characters.Length;
        characters[selectedcharacter].SetActive(true);
        characternames[selectedcharacter].enabled = true;
    }
    public void LeftButton(){
        characternames[selectednames].enabled = false;
        characters[selectedcharacter].SetActive(false);
        selectednames--;
        selectedcharacter--;
        if(selectedcharacter < 0){
            selectedcharacter += characters.Length;
        }
        if(selectednames < 0){
            selectednames += characternames.Length;
        }
        characters[selectedcharacter].SetActive(true);
        characternames[selectednames].enabled = true;
    }
    public void StartButton(){
        PlayerPrefs.SetInt("selectedcharacter", selectedcharacter);
        SceneManager.LoadScene("CenaJogo");
    }
}
