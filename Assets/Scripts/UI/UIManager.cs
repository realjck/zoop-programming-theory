using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject splashscreen;
    [SerializeField] private GameObject tutoscreen;
    [SerializeField] private GameObject menuButtons;
    private bool isMenuOpen;
    private bool isTutoSeen;
    // manage clicks
    public void ClickButtonMenu(){
        splashscreen.SetActive(false);
        if(!isTutoSeen){
            tutoscreen.SetActive(true);
            isTutoSeen = true;
        }
        ShowMenu(!isMenuOpen);
    }
    private void ShowMenu(bool visibility){
        menuButtons.SetActive(visibility);
        isMenuOpen = visibility;
    }
    public void ClickAddButton(int animalIndex){
        tutoscreen.SetActive(false);
        SpawnManager.Instance.InstantiateAnimal(animalIndex);
    }
}
