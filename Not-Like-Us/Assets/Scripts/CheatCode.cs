using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCode : MonoBehaviour
{
    private string input;
    public static bool dev = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
        input = s;
        if (input == "mohan2526")
        {
            dev = true;
            CharacterSelection.selectedCharacter = "Nikhil";
            Debug.Log("Welcome Back Nikhil");
        }
    }
}
