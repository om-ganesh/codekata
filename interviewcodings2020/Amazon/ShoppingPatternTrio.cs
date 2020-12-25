using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020.Amazon
{
    class ShoppingPatternTrio : IProblem
    {
        public void Execute()
        {
            int[] products_from = new int[] { 5,1,1,2,2,3,4 };
            int[] products_to = new int[] { 6,2,3,3,4,4,5 };
            //int[] products_from = new int[] { 1, 2, 2, 3, 4, 5 };
            //int[] products_to = new int[] { 2, 4, 5, 5, 5, 6 };
            var result = getMinScore(products_from, products_to);
            Console.WriteLine("The min score is " + result);
        }

        private int getMinScore(int[] products_from, int[] products_to)
        {
            int minScore = Int32.MaxValue;

            //Create adjacency matrix
            Dictionary<int, List<int>> productMatrix = new Dictionary<int, List<int>>();
            for(int i=0;i<products_from.Length;i++)
            {
                if(productMatrix.ContainsKey(products_from[i]))
                {
                    var currentVal = productMatrix[products_from[i]];
                    currentVal.Add(products_to[i]);
                }
                else
                {
                    productMatrix.Add(products_from[i], new List<int> { products_to[i] });
                }
            }

            for (int i = 0; i < products_to.Length; i++)
            {
                if (productMatrix.ContainsKey(products_to[i]))
                {
                    var currentVal = productMatrix[products_to[i]];
                    currentVal.Add(products_from[i]);
                }
                else
                {
                    productMatrix.Add(products_to[i], new List<int> { products_from[i] });
                }
            }

            //Filter out products that don't have at least two related products
            foreach (var kvp in productMatrix.ToArray())
            {
                if(kvp.Value.Count <2)
                {
                    productMatrix.Remove(kvp.Key);
                }
            }

            // Find possible trios
            List<List<int>> trios = GetRelatedPairTrios(productMatrix);
            //RemoveDuplicateTrios(trios);

            if(trios == null || trios.Count == 0)
            {
                return -1;
            }


            foreach(var list in trios)
            {
                productMatrix.TryGetValue(list[0], out List<int> related1);
                productMatrix.TryGetValue(list[1], out List<int> related2);
                productMatrix.TryGetValue(list[2], out List<int> related3);
                var productScore = related1.Count() + related2.Count() + related3.Count() - 6;
                if(productScore < minScore)
                {
                    minScore = productScore;
                }
            }

            return minScore;
        }

        private List<List<int>> GetRelatedPairTrios(Dictionary<int, List<int>> productMatrix)
        {
            List<List<int>> trios = new List<List<int>>();
            foreach (var kvp in productMatrix)
            {
                var trioItem1 = kvp.Key;
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    var trioItem2 = kvp.Value[i];
                    var result1 = kvp.Value.Where(x => x != kvp.Value[i]);
                    productMatrix.TryGetValue(trioItem2, out List<int> result2);
                    if (result1 != null && result2 != null)
                    {
                        
                        var trioItems3 = result2.Intersect(result1);
                        var trioList = trioItems3.Select(x => new List<int> { trioItem1, trioItem2, x });
                        trios.AddRange(trioList);
                    }
                }
            }
            return trios;
        }


        private void RemoveDuplicateTrios(List<List<int>> trios)
        {

            foreach(var item in trios.ToArray())
            {

            }
        }
    }
}
