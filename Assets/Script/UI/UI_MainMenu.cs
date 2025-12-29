using UnityEngine;

public class UI_MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewGameButton()
    {
        Debug.Log("New Game Button Pressed");
        // Add logic to start the game
    }
    public void ContinueButton()
    {
        Debug.Log("Continue Game Button Pressed");
        // Add logic to load a saved game
    }
    public void OptionsButton()
    {
        Debug.Log("Options Button Pressed");
        // Add logic to open options menu
    }
    public void ExitButton()
    {
        Debug.Log("Exit Button Pressed");
        // Add logic to exit the game
        Application.Quit();
    }
}
