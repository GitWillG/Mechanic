using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudPoker
{
    public static class ListExtentions
    {
        //TODO: Rahul extensions.
        //Also, whenever using code snip bits from the web make sure to rename things as needed to match the project's code style.
        //Make sure the code makes sense too.

        /// <summary>
        /// Shuffles the element order of the specified list.
        /// </summary>
        public static void Shuffle<T>(this IList<T> ts)
        {
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = UnityEngine.Random.Range(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }
        

    }
}
