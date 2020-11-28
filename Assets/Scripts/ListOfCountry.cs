using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfCountry : MonoBehaviour
{
   [SerializeField] private GameObject _template;
   [SerializeField] private GameObject _itemContainer;

   private Marker _marker = new Marker();

   private void Start()
   {
   }

   private void OnEnable()
   {
      var view = Instantiate(_template, _itemContainer.transform);
   }

   private void OnDisable()
   {
      //_marker.OnMarkerLongClick -= OnMarkerLongCLick;
   }

   private void OnMarkerLongCLick()
   {
      var view = Instantiate(_template, _itemContainer.transform);
      
   }
}
