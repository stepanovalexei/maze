using UnityEngine;
using UnityEngine.UI;

namespace MainMenu.Buttons
{
    public class SaveNameButton : MonoBehaviour
    {
        public InputField Field;

        private void Start() =>
            Field.text = Saved()
                ? PlayerPrefs.GetString(Constants.NameKey)
                : "Default Name";

        private static bool Saved() => PlayerPrefs.GetString(Constants.NameKey) != string.Empty;

        public void SaveName(string newName) => PlayerPrefs.SetString(Constants.NameKey, newName);
    }
}