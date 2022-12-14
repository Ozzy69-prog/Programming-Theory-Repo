using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public string nameSpace;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        loadName();
    }

   [System.Serializable]
   class SaveData
    {
        public string nameSpace;
    }

    public void SaveName()
    {
        SaveData data = new SaveData();
        data.nameSpace = nameSpace;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void loadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            nameSpace = data.nameSpace;
        }
    }
}
