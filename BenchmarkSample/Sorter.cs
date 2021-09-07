using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkSample
{
    public class Sorter
    {
        public byte[] BubbleSort(byte[] input)
        {
            byte[] result = new byte[input.Length];
            input.CopyTo(result, 0);
            bool itemMoved;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                        var temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;
                        itemMoved = true;
                    }

                }
            } while (itemMoved);
            return result;
        }

        public byte[] InlineSort(byte[] input)
        {
            byte[] result = new byte[input.Length];
            input.CopyTo(result, 0);

            for (int i=0; i < result.Length; i++)
            {
                var currentItem = result[i];
                var currentIndex = i;
                while(currentIndex > 0 && result[currentIndex - 1] > currentItem)
                {
                    result[currentIndex]=result[currentIndex - 1];
                    currentIndex--;
                }
                result[currentIndex] = currentItem;
            }
            return result;
        }
    }
}
