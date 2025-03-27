using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DealCard : MonoBehaviour
{
    [SerializeField] private List<Image> cardsPlace;
    [SerializeField] private Sprite originalSprite;
    [SerializeField] private CardDataSO cardDatabase;
    private List<CardData> cardsForSpawn = new();
    private int curIndex = 1;
    private int cardGen;
    private CardData curCard, nextCard;

    public void ChooseCards()
    {
        while (cardsForSpawn.Count < 5)
        {
            cardGen = Random.Range(0, 12);
            
            if (!cardsForSpawn.Contains(cardDatabase.cardData[cardGen]))
            {
                cardsForSpawn.Add(cardDatabase.cardData[cardGen]);
                Debug.Log($"{cardsForSpawn[cardsForSpawn.Count-1].Vol}");
            }
            
        }
        
    }

    public void ShowCard(int index)
    {
        cardsPlace[index].sprite = cardsForSpawn[index].Sprite;
        if(index < 5)
        {
            curCard = cardsForSpawn[index];
            nextCard = cardsForSpawn[index + 1];
        }
        else
        {
            Debug.Log("Stop");
            ResetGame();
            
        }
    }

    public void HighCard()
    {
        ShowCard(curIndex);
        if (cardsForSpawn[curIndex-1].Vol > curCard.Vol)
        {
            Debug.Log("Stop High");
            ResetGame();
        }
        else
        {
            curIndex += 1;
            
        }
        
    }

    public void LowCard()
    {
        ShowCard(curIndex);
        if (curCard.Vol > cardsForSpawn[curIndex-1].Vol)
        {
            Debug.Log($"Stop Low");
            ResetGame();
        }
        else
        {
            curIndex += 1;

        }
    }

    public void GameOver()
    {
        ResetGame();
    }

    private void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
