using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupHover : MonoBehaviour {

    public GameObject popupText;
    public GameObject popup;

    public void OnEnterAST()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Astroemeria: Symbol of wealth, prosperity, and friendship.");

    }
    public void OnExit()
    {
        gameObject.SetActive(false);
    }
    public void OnEnterBIRD()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Bird of Paradise: Symbol of joy, excitement and anticipation.");
    }
    public void OnEnterCAR()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Carnation(White): Symbol of innocence and pure love.");
    }
    public void OnEnterSTAT()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Statice: Symbol of sympathy and success.");
    }
    public void OnEnterSF()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Sunflower: Symbol of adoration and dedication.");
    }
    public void OnEnterDAF()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Daffodil: Symbol of new beginnings and joy.");
    }
    //ccolumn 2
    public void OnEnterOR()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Orchid: Symbol of exotic, mature beauty and femininity.");
    }
    public void OnEnterTU()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Tulip: Symbol of fame and perfection.");
    }
    public void OnEnterSNA()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Snapdragon: Symbol of grace and protection.");
    }
    public void OnEnterHYD()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Hydrangea: Symbol of gratitude, empathy or heartlessness.");
    }
    public void OnEnterPEO()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Peony: Symbol of compassion, happy life, prosperity, or shame.");
    }
    public void OnEnterROSE()
    {
        gameObject.SetActive(true);
        popupText.gameObject.GetComponent<Text>().text = ("Rose(Red): Symbol of love, desire and admiration.");
    }

}
