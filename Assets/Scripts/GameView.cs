using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;


public class GameView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TipTextTitle;
    [SerializeField] private TextMeshProUGUI TipTextDescrition;
    [SerializeField] private TipsSO TipToShow;
    //[SerializeField] private float TipDuration;

    [SerializeField] PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement.OnShowTip += ShowView;
           
    }


    private void OnDisable()
    {
        playerMovement.OnShowTip -= ShowView;
    }


    async void ShowView(TipsSO activeTip)
    {
        activeTip = TipToShow;
        TipTextTitle.text = activeTip.showtitle();
        TipTextDescrition.text = activeTip.Showdescription();
        await Task.Delay(TipToShow.durationInMiliseconds);
        TipTextTitle.text = " ";
        TipTextDescrition.text = " ";
    }

    
}
