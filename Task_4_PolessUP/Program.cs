//Учитывая целочисленный массив nums, вернуть третье максимальное число в этом массиве. Если третьего максимума не существует, вернуть максимальное число.
//Ввод: nums = [2, 3, 1]
//Вывод: 1
//Объяснение:
//Первый отчетливый максимум равен 3.
//Второй отчетливый максимум равен 2.
//Третий отчетливый максимум равен 1.

using System.Net.Http.Headers;
static int ThirdMax(int[] nums)
{
    int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;
    // Находим максимальное число
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > max1)
        {
            max1 = nums[i];
        }
    }
    // Находим второе максимальное число
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != max1 && nums[i] > max2)
        {
            max2 = nums[i];
        }
    }
    // Находим третье максимальное число
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != max1 && nums[i] != max2 && nums[i] > max3)
        {
            max3 = nums[i];
        }
    }
    // Если третьего максимума не существует, возвращаем максимальное число
    if (max3 == int.MinValue)
    {
        return max1;
    }
    return max3;
}

int[] nums = {1,2,3,4,5};
int result = ThirdMax(nums);
Console.WriteLine(result);
