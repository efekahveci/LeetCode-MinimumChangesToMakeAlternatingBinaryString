// Verilen s tringi içersinde sadece 0 ve 1 karakterleri bulunmaktadır. Herhangi bir karakteri 0 veya 1 ile değiştirebiliyoruz.
// Yanyana 2 adet 0 veya 1 olmaması gerekiyor. Yani 00 veya 11 olmamalı.

// Bu işlem için minimum kaç değişiklik yapılması gerektiğini bulmamız gerekiyor.

//Example 0100; -> 1 = 0101

Console.WriteLine(MinOperations("0001"));
Console.ReadLine();

int MinOperations(string s)
{
    int count = 0;
    var sb = new System.Text.StringBuilder(s); // StringBuilder kullanarak string s'yi modifiye edilebilir hale getiriyoruz.
    var temp = '0';
    var changeValue = '0';

    for (int i = 0; i < sb.Length - 1; i++) // Döngüdeki sınır koşulu doğru.
    {
        temp = sb[i] == '0' ? '0' : '1';
        changeValue = temp == '0' ? '1' : '0';

        if (temp == sb[i + 1])
        {
            count++;
            sb[i + 1] = changeValue; // StringBuilder kullanarak string'i değiştirebiliyoruz.
        }
    }
    return count;
}
