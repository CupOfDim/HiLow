using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardControl : MonoBehaviour
{
    [SerializeField] private List<Image> cardsPlace = new();

    void Start()
    {
        ChooseCard();
    }

    private void ChooseCard()
    {
        throw new NotImplementedException();
    }
}
