using UnityEngine;

public class RecordManager : MonoBehaviour // Este script sirve para controlar si se ha superado el record o no.
{
    /*--------------------------------------------------- SINGLETONS --------------------------------------------------- */
    public static RecordManager Instance = null;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    /*------------------------------------------------------------------------------------------------------------------ */
    public void CheckScoreRecord(int n)
    {
        if (n > PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Score", n);
        }
    }
}
