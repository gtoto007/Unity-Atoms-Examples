using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// A healthbar component that sets the fill amount of its associated UI Image accordingly.
    /// </summary>
    public class MyHealthBar : MonoBehaviour
    {

        [SerializeField]
        private Image _image;

        void Awake()
        {
            if (_image == null)
            {
                _image = GetComponent<Image>();
            }
        }

        public void HealthChanged(int health)
        {
           //your logic
        } 
    }
}
