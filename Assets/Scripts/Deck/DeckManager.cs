using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    private List<CharacterCard> _allCard = new List<CharacterCard>();
    private List<CharacterCard> _frontCard = new List<CharacterCard>();
    private List<CharacterCard> _backCard = new List<CharacterCard>();

    void Awake()
    {

    }

    public ref List<CharacterCard> GetFrontCard()
    {
        return ref this._frontCard;
    }
    public ref List<CharacterCard> GetBackCard()
    {
        return ref this._backCard;
    }
    public ref List<CharacterCard> GetAllCard()
    {
        return ref this._allCard;
    }
}
