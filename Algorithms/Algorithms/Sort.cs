namespace Algorithms
{
    public static class Sort
    {
        public static List<int> Bubble (List<int> list)
        {
            bool flag;
            for (int borderRight = list.Count; borderRight > 0; borderRight--)
            {
                flag = true;

                for (int i = 0; i < borderRight - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;

                        flag = false;
                    }
                }

                if (flag) break;
            }

            return list;
        }

        public static List<int> Quick(List<int> list)
        {
            if (list.Count < 2)
                return list;

            List<int> lesser_values = new List<int>();
            List<int> same_values = new List<int>();
            List<int> larger_values = new List<int>();

            int pivot = list[0];

            foreach (var elem in list) 
            {
                if (elem < pivot)
                    lesser_values.Add(elem);
                else if (elem == pivot)
                    same_values.Add(elem);
                else
                    larger_values.Add(elem);
            }

            List<int> lesser_values_sorted = Quick(lesser_values);
            List<int> larger_values_sorted = Quick(larger_values);

            return lesser_values_sorted.Union(same_values).Union(larger_values_sorted).ToList();
        }
    }
}