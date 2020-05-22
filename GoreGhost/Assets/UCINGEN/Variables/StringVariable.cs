using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New String Variable", menuName = "UCINGEN/Variables/String")]
    public class StringVariable : ScriptableObject
    {
        public string Text;

        public void SetValue(string text)
        {
            Text = text;
        }

        public void AddText(string text)
        {
            Text += text;
        }
    }
}
