using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    internal class ObjectDB
    {
        public static List<IGameObject> AllGameObjects = new List<IGameObject>();
        public static void AddNewObject(params IGameObject[] gameObject)
        {
            foreach(IGameObject gameObject1 in gameObject)
            {
                AllGameObjects.Add(gameObject1);
            }
        }
        public static void UpdateAll()
        {
            for(int i = 0; i < AllGameObjects.Count; i++)
            {
                AllGameObjects[i].Update();
            }
        }
        public static void DrawAll()
        {
            for(int i = 0 ; i < AllGameObjects.Count;i++)
            {
                AllGameObjects[i].Draw();
            }
        }
    }
}
