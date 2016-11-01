using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MatchSetupScreen : MonoBehaviour {

    [SerializeField]
    private Button hotSeatYesButton;
    [SerializeField]
    private Button hotSeatNoButton;
    [SerializeField]
    private Button playerAmountPlusButton;
    [SerializeField]
    private Button playerAmountMinusButton;
    [SerializeField]
    private Button backToMainButton;
    [SerializeField]
    private Button startGameButton;

    [SerializeField]
    private Text playerAmountText;

    [SerializeField]
    private int hotSeatPlayerAmount;
    [SerializeField]
    private int sceneToChangeTo;
    [SerializeField]
    private bool hotSeatMode;

    void SwitchHotSeat()
    {
        if (hotSeatMode == false)
        {
            hotSeatMode = true;
        }
        else { hotSeatMode = false; }
    }

    void IncrementHotSeatPlayers()
    {
        hotSeatPlayerAmount++;
    }

    void DecrementHotSeatPlayers()
    {
        hotSeatPlayerAmount--;
    }

    void ConvertPlayerAmountIntToString()
    {
        //playerAmountText = hotSeatPlayerAmount.ToString();
    }

    void StartGame()
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
