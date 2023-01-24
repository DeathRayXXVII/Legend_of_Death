using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Tools.MatchingGameScripts
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextLabelBehavior : MonoBehaviour
    {
        public TextMeshProUGUI label;
        public UnityEvent startEvent;

        private void Start()
        {
            label = GetComponent<TextMeshProUGUI>();
            startEvent.Invoke();
        }

        public void UpdateLabel(floatData obj)
        {
            label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        }

        public void UpdateLabel(intData obj)
        {
            label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        }

    }
}
