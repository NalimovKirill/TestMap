using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Countries;
using UI;
using UnityEngine;
using TMPro;

public class AddCountry : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private GameObject _itemContainer;

    private CountryType _countryType;
    private Country _country;
    private Menu _menu = new Menu();
    private Marker _marker = new Marker();
    private void Start()
    {
        _country = CountryData.GetCountryByEnum(_countryType);
        GameEvents.current.onMarkerLongClick += OnAddCountry;
        
    }

    private void OnAddCountry()
    {
        foreach (var tmpText in _template.GetComponentsInChildren<TMP_Text>().ToList())
        {
            if (tmpText.name == "CountryText")
            {
                tmpText.text = _country.Name;
            }
            if (tmpText.text == "SquareText")
            {
                tmpText.text = _country.square.ToString();
            }
            if (tmpText.text == "PopulationText")
            {
                tmpText.text = _country.population.ToString();
            }
            if (tmpText.text == "VvpText")
            {
                tmpText.text = _country.vvp.ToString();
            }
        }
        var view = Instantiate(_template, _itemContainer.transform);
        Debug.Log("Добавили страну");
        
    }
    
}
