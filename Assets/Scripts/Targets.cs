using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Targets : MonoBehaviour {

    [SerializeField]
    private float score = 0f; // score counter
    [SerializeField]
    private Text scoreText; // visual score text in editor
    [SerializeField]
    private bool lowTarget = false;
    [SerializeField]
    private bool mediumTarget = false;
    [SerializeField]
    private bool highTarget = false;

    void Update()
    {
        scoreText.text = "Score:" + ((int)score).ToString(); 
    }

    public void OnTriggerEnter(Collider other) // Coliders for adding score 
    {

        if (other.CompareTag("lowtarget"))
        {
            lowTarget = true;
            mediumTarget = false;
            highTarget = false;
        }

        if (other.CompareTag("mediumtarget"))
        {
            mediumTarget = true;
            lowTarget = false;
            highTarget = false;
        }

        if (other.CompareTag("hightarget"))
        {
            highTarget = true;
            lowTarget = false;
            mediumTarget = false;
        }

        if (other.CompareTag("outofbounds"))
        {
            lowTarget = false;
            mediumTarget = false;
            highTarget = false;
        }

        if (lowTarget == true) // added scores dependant on the target indication 
        {
            score += 10;
        }

        if (mediumTarget == true)
        {
            score += 20;
        }

        if (highTarget == true)
        {
            score += 30;
        }

    }
}
