using TMPro;
using UnityEngine;

namespace UI
{
    public class Menu : MonoBehaviour
    {
        [SerializeField] private TMP_Text _square;
        [SerializeField] private TMP_Text _vvp;
        [SerializeField] private TMP_Text _population;
        
        public void OpenPanel(GameObject panel)
        {
            panel.SetActive(true);
            //Time.timeScale = 0;
        }

        public void ClosePanel(GameObject panel)
        {
            panel.SetActive(false);
            //Time.timeScale = 1;
        }
    
        public void SetCountry(Country country)
        {
            _square.text = country.square.ToString();
            _population.text = country.population.ToString();
            _vvp.text = country.vvp.ToString();
        }
    }
}
