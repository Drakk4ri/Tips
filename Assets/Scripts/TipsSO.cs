using System.Collections;
using TMPro;
using UnityEngine;
using System.Threading.Tasks;



[CreateAssetMenu(fileName = "TipsScriptableObject", menuName = "ScriptableObjects/Tips")]

public class TipsSO : ScriptableObject
{
    [SerializeField] private string title = " ";
    [SerializeField] private string description = " ";
    public int durationInMiliseconds = 2000;


    public string Showdescription()
    {
        return description;
    }
    public string showtitle()
    {
        return title;
    }
}
