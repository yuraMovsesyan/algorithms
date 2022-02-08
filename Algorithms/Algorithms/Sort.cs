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
    }
}