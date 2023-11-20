using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*--------------------------------------------------- SINGLETONS --------------------------------------------------- */
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }
    /*------------------------------------------------------------------------------------------------------------------ */

    [SerializeField] public TMP_Text player1ScoreText;
    [SerializeField] public TMP_Text score;

    public int playerScored;

    private void Start() //Para mostrar la puntuación una vez se ejecute el juego
    {
        player1ScoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }
    public void PlayerScored() // Para aumentar la puntuación del jugador.
    {

        if (PlayerPrefs.GetInt("Rifle") == 1)
        {
            playerScored++;
        }
        if (PlayerPrefs.GetInt("Rifle") == 2)
        {
            playerScored = playerScored + 2;
        }
        if (PlayerPrefs.GetInt("Rifle") == 3)
        {
            playerScored = playerScored + 3;
        }
        RecordManager.Instance.CheckScoreRecord(playerScored);
        player1ScoreText.text = PlayerPrefs.GetInt("Score").ToString();
        score.text = playerScored.ToString();
    }
}
