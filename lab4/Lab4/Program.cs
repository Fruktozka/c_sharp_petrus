/* Завдання
 * 19.Даний масив розміру N. Знайти номери двох найближчих чисел з цього масиву. 
 */

int[] nums = new int[5];
int min = 0;
int tmpMin = 0;
int res1 = 0;
int res2 = 0;

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"input nums[{i}] ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

min = Math.Abs(nums[0]-nums[1]);
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (i != j)
        {
            tmpMin = Math.Abs(nums[i] - nums[j]);
            if (tmpMin < min)
            {
                min = tmpMin;
                res1 = i;
                res2 = j;
            }
        }
    }
}

Console.WriteLine($"nums[1] = {nums[res1]} nums[2] = {nums[res2]} first position = {res1} second position = {res2}");
