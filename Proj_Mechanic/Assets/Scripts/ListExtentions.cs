using System.Collections.Generic;
using UnityEngine;

namespace StudPoker
{
    public static class ListExtentions
    {
        public static void Shuffle<T>(this IList<T> initList)
        {
            var count = initList.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = Random.Range(i, count);
                var tmp = initList[i];
                initList[i] = initList[r];
                initList[r] = tmp;
            }
        }
    }
}
