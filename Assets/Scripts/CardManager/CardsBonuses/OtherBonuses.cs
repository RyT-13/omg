using UnityEngine;
using static EnemiesStats;

public class OtherBonuses : MonoBehaviour
{
    private CardManager _cardManager;
    public void Init(CardManager cardManager)
    {
        _cardManager = cardManager;
    }

    public void IncreaseCoinsValue()
    {
        AnyGoblin.DoForAllElements("coinsForDeath", 5);
        DeletingCards();
    }
    
    private void DeletingCards()
    {
        _cardManager.DeleteCardFromList("other");
        _cardManager.DestroyCards();
    }

    public void SlowDownTheEnemy()
    {
        AnyGoblin.DoForAllElements("speed", -0.9f);
        DeletingCards();
    }

    public void IncreaseDamageAreaRadius()
    {
        BuildingsStats.AnyBuilding.Castle.attackRadius *= 2;
    }
}
