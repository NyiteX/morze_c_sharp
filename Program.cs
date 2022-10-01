Console.WriteLine("Введите текст для шифровки: ");
Morze M = new();
M.Text = Console.ReadLine();
M.Encription(M.Text);

class Morze
{
    string? text;
    public string? Text
    {
        get => text; set => text = value;
    }
    public void Encription(string? str)
    {
        str = text;
        str = str.ToUpper();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'А' || str[i] == 'A') Console.Write(".-");
            if (str[i] == 'Б' || str[i] == 'B') Console.Write("-...");
            if (str[i] == 'В' || str[i] == 'W') Console.Write(".--");
            if (str[i] == 'Г' || str[i] == 'G') Console.Write("--.");
            if (str[i] == 'Д' || str[i] == 'D') Console.Write("-..");
            if (str[i] == 'Е' || str[i] == 'Ё' || str[i] == 'E') Console.Write(".");
            if (str[i] == 'Ж' || str[i] == 'V') Console.Write("...-");
            if (str[i] == 'З' || str[i] == 'Z') Console.Write("--..");
            if (str[i] == 'И' || str[i] == 'I') Console.Write("..");
            if (str[i] == 'Й' || str[i] == 'J') Console.Write(".---");
            if (str[i] == 'К' || str[i] == 'K') Console.Write("-.-");
            if (str[i] == 'Л' || str[i] == 'L') Console.Write(".-..");
            if (str[i] == 'М' || str[i] == 'M') Console.Write("--");
            if (str[i] == 'Н' || str[i] == 'N') Console.Write("-.");
            if (str[i] == 'О' || str[i] == 'O') Console.Write("---");
            if (str[i] == 'П' || str[i] == 'P') Console.Write(".--.");
            if (str[i] == 'Р' || str[i] == 'R') Console.Write(".-.");
            if (str[i] == 'С' || str[i] == 'S') Console.Write("...");
            if (str[i] == 'Т' || str[i] == 'T') Console.Write("-");
            if (str[i] == 'У' || str[i] == 'U') Console.Write("..-");
            if (str[i] == 'Ф' || str[i] == 'F') Console.Write("..-.");
            if (str[i] == 'Х' || str[i] == 'H') Console.Write("....");
            if (str[i] == 'Ц' || str[i] == 'C') Console.Write("-.-.");

            if (str[i] == 'Ч') Console.Write("---.");
            if (str[i] == 'Ш') Console.Write("----");
            if (str[i] == 'Щ' || str[i] == 'Q') Console.Write("--.-");
            if (str[i] == 'Ь' || str[i] == 'Ъ' || str[i] == 'X') Console.Write("-..-");
            if (str[i] == 'Ы' || str[i] == 'Y') Console.Write("-.--");
            if (str[i] == 'Э') Console.Write("..-..");
            if (str[i] == 'Ю') Console.Write("..--");
            if (str[i] == 'Я') Console.Write(".-.-");

            if (str[i] == '1') Console.Write(".----");
            if (str[i] == '2') Console.Write("..---");
            if (str[i] == '3') Console.Write("...--");
            if (str[i] == '4') Console.Write("....-");
            if (str[i] == '5') Console.Write(".....");
            if (str[i] == '6') Console.Write("-....");
            if (str[i] == '7') Console.Write("--...");
            if (str[i] == '8') Console.Write("---..");
            if (str[i] == '9') Console.Write("----.");
            if (str[i] == '0') Console.Write("-----");
        }
        Console.WriteLine();
    }
}