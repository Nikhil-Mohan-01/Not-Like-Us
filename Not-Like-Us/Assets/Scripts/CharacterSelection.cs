using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public static string selectedCharacter;

    public GameObject KendrickPlayer;
    public GameObject NikhilPlayer;

    public void KendrickSelect()
    {
        selectedCharacter = "Kendrick";
    }

    public void NikhilSelect()
    {
        selectedCharacter = "Nikhil";
    }

    public void LoadPlayer()
    {
        SceneManager.LoadScene("Game");
    }
}
