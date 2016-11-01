using UnityEngine;
using System.Collections;

public class RoundSystem : MonoBehaviour {

    [SerializeField]
    private int playerAmount;
    [SerializeField]
    private int hotSeatPlayerAmount;
    [SerializeField]
    private int whosTurn;

    [SerializeField]
    private bool hotSeatMode;

    void ResetParameters()
    {
        playerAmount = 0;
        hotSeatPlayerAmount = 0;
        whosTurn = 1;
        hotSeatMode = false;
    }

	void InitializeFirstRound () {
        if (hotSeatMode == true)
        {
            playerAmount = hotSeatPlayerAmount;
        }
        else { playerAmount = 2; }
        whosTurn = 1;
	
	}

    void AdvanceTurn()
    {
        if (whosTurn >= playerAmount)
        {
            whosTurn = 1;
        }
        else { whosTurn++; }
    }
}
