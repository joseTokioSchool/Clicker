using UnityEngine;

public class SelectedRifle : MonoBehaviour // Este script sirve para seleccionar que rifle queremos usar en la partida.
{
    [SerializeField] GameObject selectedWoodText;
    [SerializeField] GameObject selectedSilverText;
    [SerializeField] GameObject selectedGoldText;

    public void WoodRifleSelected()
    {
        selectedWoodText.SetActive(true);
        selectedSilverText.SetActive(false);
        selectedGoldText.SetActive(false);
        PlayerPrefs.SetInt("Rifle", 1);
    }
    public void SilverRifleSelected()
    {
        selectedWoodText.SetActive(false);
        selectedSilverText.SetActive(true);
        selectedGoldText.SetActive(false);
        PlayerPrefs.SetInt("Rifle", 2);
    }
    public void GoldRifleSelected()
    {
        selectedWoodText.SetActive(false);
        selectedSilverText.SetActive(false);
        selectedGoldText.SetActive(true);
        PlayerPrefs.SetInt("Rifle", 3);
    }
}
