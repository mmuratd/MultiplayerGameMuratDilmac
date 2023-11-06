using UnityEditor;
using UnityEngine;

public class CustomWindowFolder : EditorWindow
{
    [MenuItem("MyTools/Create Custom Folders")]
    static void ShowWindow()
    {
        CustomWindowFolder window = GetWindow<CustomWindowFolder>("Custom Folder Creator Tool");
        window.Show();
    }

    private string[] customFolderNames = new string[] { "Prefabs", "Scenes", "Sprites","Materials","DenemeFolder1","DenemeFolder2" };  // Olu�turmak istedi�iniz dosya adlar�n� burada belirtin

    void OnGUI()
    {
        GUILayout.Label("Create Custom Folders", EditorStyles.boldLabel);
        if (GUILayout.Button("Create all files"))
        {
            foreach (string folderName in customFolderNames)
            {
                
                    string path = "Assets/" + folderName;

                    if (!AssetDatabase.IsValidFolder(path))
                    {
                        AssetDatabase.CreateFolder("Assets", folderName);
                        Debug.Log("Klas�r olu�turuldu: " + path);
                    }
                    else
                    {
                        Debug.LogWarning("Klas�r zaten var: " + path);
                    }
                
            }
        }
    }
}

