using System;
using TMPro;
using UnityEngine;

namespace Combat.Damage
{
    public class DamageReceiver : MonoBehaviour, IDamageReceiver
    {
        [SerializeField] private TextMeshProUGUI[] _damageTexts;
        private int _lastTextUsed;

        private void Awake()
        {
            foreach (var damageText in _damageTexts)
            {
                damageText.SetText(string.Empty);
            }
        }

        public void ReceiveDamage(int damage, Color color)
        {
            var textIndex = GetTextIndexToUse();
            
            _damageTexts[textIndex].SetText(damage.ToString());
            _damageTexts[textIndex].color = color;

            _lastTextUsed = textIndex;
        }

        private int GetTextIndexToUse()
        {
            return (_lastTextUsed + 1) % _damageTexts.Length;
        }
    }
}
