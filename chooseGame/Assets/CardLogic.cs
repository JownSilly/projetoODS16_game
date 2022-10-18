using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CardLogic : MonoBehaviour
{
    public delegate void DDecision(string result);
    public event DDecision decisaoTomada;
    public TMP_Text tmp;
    public bool isMouseOver = false;
    public bool cardmoved;
    private void OnMouseOver()
    {
        isMouseOver = true; ;
        
    }
    private void OnMouseExit()
    {
        isMouseOver = false;
    }
    public void InduceRight()
    {
        tmp.text = "Bobaooo";
        Destroy(gameObject);
    }
    public void InduceLeft()
    {
        tmp.text = "eta";
        Destroy(gameObject);
    }
}
