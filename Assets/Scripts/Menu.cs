using UnityEngine;
using UnityEngine.UI;  // benodigheden voor Ui en Scene management ( laden / sluiten van scenes )
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {

    [SerializeField]
     private Canvas startMenu;
    [SerializeField]
    private Button playButton;
    [SerializeField]
    private Button quitButton;




    void Start()

    {
        startMenu = startMenu.GetComponent<Canvas>();  // aanroepen Canvassen en buttons -- Tyrone
        playButton = playButton.GetComponent<Button>();
        quitButton = quitButton.GetComponent<Button>();
    }

    
    public void ProfileLevel()
    {
        SceneManager.LoadScene("MatchSetup");
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}
