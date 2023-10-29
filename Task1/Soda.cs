namespace Task1
{
    public class Soda
    {
        string taste = string.Empty;
        Soda(string taste)
        {
            this.taste = taste;
        }
        public string WhatTaste()
        {
            if (String.IsNullOrEmpty(taste))
            {
                return "У вас обычная газировка";
            }
            return $"Ваша газировка {taste}";
        }
    }
}
