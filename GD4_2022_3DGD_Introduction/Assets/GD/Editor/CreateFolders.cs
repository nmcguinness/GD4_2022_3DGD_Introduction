using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace GD
{
    /// <summary>
    /// Creates a consistent folder system under a user defined project name
    /// Access from "GD/Utils/Create Project Folders" in the main menu
    /// </summary>
    /// <see cref="https://unity.com/how-to/organizing-your-project"/>
    public class CreateFolders : EditorWindow
    {
        private static string projectName = "GD";

        public static List<string> folders = new List<string>() { "Scenes", "Scripts", "Data", "Animation", "Audio", "Materials", "Meshes", "Prefabs", "Textures", "Sprites" };

        [MenuItem("Tools/GD/Utils/Create project folders...")]
        private static void ShowProjectPopup()
        {
            CreateFolders window = CreateInstance<CreateFolders>();
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 400, 150);
            window.ShowPopup();
        }

        private static void CreateAllFolders()
        {
            List<string> folders = new List<string>
        {
            "Animations",
            "Audio",
            "Data",
            "Editor",
            "Materials",
            "Meshes",
            "Prefabs",
            "Scripts",
            "Scenes",
            "Shaders",
            "Textures",
            "UI",
        };

            foreach (string folder in folders)
            {
                string fullPath = $"Assets/{projectName}/{folder}";

                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }
            }

            AssetDatabase.Refresh();
        }

        private void OnGUI()
        {
            EditorGUILayout.LabelField("Enter the project name used as the root folder:");
            projectName = EditorGUILayout.TextField("Project Name: ", projectName);
            Repaint();
            GUILayout.Space(10);
            if (GUILayout.Button("Create Folders"))
            {
                CreateAllFolders();
                Close();
            }

            if (GUILayout.Button("Cancel"))
            {
                Close();
            }
        }
    }
}