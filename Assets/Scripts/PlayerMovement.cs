using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public event Action<TipsSO> OnShowTip;

    [SerializeField] TipsSO tipToShow;
    [SerializeField] private float movementSpeed = 10;

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (OnShowTip != null)
        {
            OnShowTip(tipToShow);
        }

    }

}
