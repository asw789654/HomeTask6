namespace Task1
{
    public class Soda
    {
        string taste ;
        public Soda(string taste = null)
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
