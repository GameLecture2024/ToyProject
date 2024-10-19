using UnityEditor;
using UnityEngine;
using System.IO;


namespace Utility_Create
{
    public class Setup
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Folders.CreateDefault("Shooting Game", "Animation", "Art", "Materials", "Prefabs", "Scripts");
            AssetDatabase.Refresh();
        }


        static class Folders
        {
            public static void CreateDefault(string root, params string[] folders)
            {
                var fullpath = Path.Combine(Application.dataPath, root);
                foreach (var folder in folders)
                {
                    var path = Path.Combine(fullpath, folder);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
            }
        }



    } 
}
